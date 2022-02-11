using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnTaskWeb.Domain.Models.ChessTask
{
    public class ChessFigure
    {
        protected ChessFigure _figure;

        protected virtual void FillBoard(ChessBoard board)
        {
            Console.WriteLine("Fill in the figures on the board");
        }

        public virtual bool IsPossibleMove(int x, int y)
        {
            return false;
        }

    }

}
