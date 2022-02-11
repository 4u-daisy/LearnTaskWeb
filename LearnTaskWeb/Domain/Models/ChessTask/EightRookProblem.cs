using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnTaskWeb.Domain.Models.ChessTask
{
    public class EightRookProblem : ChessFigure
    {
        protected override void FillBoard(ChessBoard board)
        {
            int x = board.xCoordinate;
            int y = board.yCoordinate;

            for(var i = 0; i < board.SIZE_Board; i++)
            {
                board._chessBoard[(i + x) % 8][(i + y) % 8] = true;
            }
        }

        public override bool IsPossibleMove(int x, int y)
        {
            return false;
        }

    }
}
