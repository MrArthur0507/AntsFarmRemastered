using AntsFarm.Engine.BoardGenerator.Implementation;
using AntsFarm.Engine.Factory;
using AntsFarm.Engine.Mediator.Implementation;
using AntsFarm.Models.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntsFarm.Engine.Engine.Implementation
{
    public class AntsEngine
    {
        private readonly int antsCount;

        private readonly int grainsCount;

        private readonly int grainsMaxCount;

        private readonly BoardCreator boardGenerator;

        private  IBoard board;

        private readonly QueenMediator farmMediator;
        private readonly AntFactory antFactory;

        private void Setup(int size)
        {
            board = boardGenerator.GenerateBoard(size);
        }

        public void Start()
        {
            Setup(20);
            
        }
    }
}
