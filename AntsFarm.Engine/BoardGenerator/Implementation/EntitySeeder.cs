using AntsFarm.Models.Entities.Implementations;
using AntsFarm.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.BoardGenerator.Implementation
{
    public class EntitySeeder
    {
        private readonly Random random;
        private readonly EntityGenerator entityGenerator;
        public EntitySeeder() {
            random = new Random();
            entityGenerator = new EntityGenerator();
        }
        private int grainCount = 0;
        public void SeedBoard(IBoard board, int maxGrainCount)
        {
            for (int i = 0; i < board.GetLength(); i++)
            {
                for (int j = 0; j < board.GetLength(); j++)
                {
                    if (grainCount < maxGrainCount)
                    {
                        board[i, j] = new Tile(new Grain());
                        board.GrainPositions.Add(new System.Drawing.Point(i, j));
                        grainCount++;
                    } else
                    {
                        board[i, j] = new Tile(entityGenerator.GenerateEntity());
                        if (board[i, j].BaseTile.GetType() == typeof(Grain))
                        {
                            board.GrainPositions.Add(new System.Drawing.Point(i, j));
                        }
                    }
                    
                }
            }

            board[board.GetLength() - 1, board.GetLength() - 1] = new Tile(new BaseQueen());
            board.QueenPosition = new System.Drawing.Point(board.GetLength() - 1, board.GetLength() - 1);
            
        }



    }
}
