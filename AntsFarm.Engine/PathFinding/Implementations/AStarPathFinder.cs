using AntsFarm.Engine.PathFinding.Interfaces;
using AntsFarm.Models.Entities.Implementations.Base;
using AntsFarm.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.PathFinding.Implementations
{
    public class AStarPathFinder : IPathFinder
    {
        private readonly IBoard b;

        public AStarPathFinder(IBoard board)
        {
            b = board;
        }
        public List<Point> FindPath(Point start, Point end)
        {
            Dictionary<Point, Node> allNodes = new Dictionary<Point, Node>();
            List<Node> openList = new List<Node>();
            HashSet<Point> closedList = new HashSet<Point>();

            Node startNode = new Node(start) { CostG = 0, CostH = GetHeuristic(start, end) };
            allNodes[start] = startNode;
            openList.Add(startNode);

            while (openList.Count > 0)
            {
                openList.Sort((a, b) => a.CostF.CompareTo(b.CostF));
                Node current = openList[0];
                openList.RemoveAt(0);

                if (current.Position == end)
                {
                    return RetracePath(startNode, current);
                }

                closedList.Add(current.Position);

                foreach (var neighbor in GetNeighbors(current.Position, b))
                {
                    if (closedList.Contains(neighbor.Position))
                        continue;

                    PathFindableEntity entity = (PathFindableEntity)b[neighbor.Position.X, neighbor.Position.Y];
                    if (!entity.IsWalkable)
                        continue;

                    Node neighborNode;
                    if (!allNodes.ContainsKey(neighbor.Position))
                    {
                        neighborNode = new Node(neighbor.Position) { CostG = int.MaxValue };
                        allNodes[neighbor.Position] = neighborNode;
                    }
                    else
                    {
                        neighborNode = allNodes[neighbor.Position];
                    }

                    int tentativeGScore = current.CostG + 1;
                    if (tentativeGScore < neighborNode.CostG)
                    {
                        neighborNode.Parent = current;
                        neighborNode.CostG = tentativeGScore;
                        neighborNode.CostH = GetHeuristic(neighbor.Position, end);

                        if (!openList.Contains(neighborNode))
                            openList.Add(neighborNode);
                    }
                }
            }
            return new List<Point>();
        }


        private List<Point> RetracePath(Node startNode, Node endNode)
        {
            List<Point> path = new List<Point>();
            Node currentNode = endNode;

            while (currentNode != startNode)
            {
                path.Add(currentNode.Position);
                currentNode = currentNode.Parent;
            }
            path.Reverse();
            return path;
        }

        private int GetHeuristic(Point from, Point to)
        {
            return Math.Abs(from.X - to.X) + Math.Abs(from.Y - to.Y);
        }

        private IEnumerable<Node> GetNeighbors(Point position, IBoard b)
        {
            var directions = new Point[] {
            new Point(1, 0), new Point(-1, 0), new Point(0, 1), new Point(0, -1)
            };

            foreach (var dir in directions)
            {
                Point neighborPos = new Point(position.X + dir.X, position.Y + dir.Y);
                if (neighborPos.X >= 0 && neighborPos.Y >= 0 && neighborPos.X < b.GetLength() && neighborPos.Y < b.GetLength())
                    yield return new Node(neighborPos);
            }
        }
    }
}
