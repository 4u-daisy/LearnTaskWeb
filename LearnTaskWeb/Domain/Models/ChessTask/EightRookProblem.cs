using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnTaskWeb.Domain.Models.ChessTask
{
    public class EightRookProblem : ChessFigure
    {
        public EightRookProblem()
        {
            _xCoordinate = 0;
            _yCoordinate = 0;
            _board = new ChessBoard(_xCoordinate, _yCoordinate);
        }
        public EightRookProblem(int x, int y)
        {
            _xCoordinate = x;
            _yCoordinate = y;
            _board = new ChessBoard(_xCoordinate, _yCoordinate);
        }
        public ChessBoard Board { get { return _board; } }

        public override void FillBoard()
        {
            int x = _board.xCoordinate;
            int y = _board.yCoordinate;

            for (var i = 0; i < _board.SIZE_Board; i++)
            {
                _board._chessBoard[(i + x) % 8][(i + y) % 8] = true;
            }
        }

        public override bool IsPossibleMove(int x, int y)
        {
            return false;
        }

    }
}
