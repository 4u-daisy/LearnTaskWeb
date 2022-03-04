using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnTaskWeb.Domain.Models.ChessTask
{
    public class ChessFigure
    {
        protected ChessBoard _board;
        protected int _xCoordinate;
        protected int _yCoordinate;

        public virtual void FillBoard()
        {
            Console.WriteLine("Fill in the figures on the board");
        }

        public virtual bool IsPossibleMove(int x, int y)
        {
            return false;
        }


    }

}
