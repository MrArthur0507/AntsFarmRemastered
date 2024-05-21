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
        
        public void SeedBoard(IBoard board)
        {
            for (int i = 0; i < board.GetLength(); i++)
            {
                for (int j = 0; j < board.GetLength(); j++)
                {
                    board[i, j] = entityGenerator.GenerateEntity();
                    if (board[i, j].GetType() == typeof(Grain)) {
                        board.GrainPositions.Add(new System.Drawing.Point(i, j));
                    }
                }
            }
            
        }



    }
}
