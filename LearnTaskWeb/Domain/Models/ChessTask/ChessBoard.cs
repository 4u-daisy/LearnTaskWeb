using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LearnTaskWeb.Domain.Models.ChessTask
{
    public class ChessBoard
    {
        public readonly int SIZE_Board = 8;

        public bool[][] _chessBoard;        //TO DO ovveride operator[][]
        private int _xCoordinate;
        private int _yCoordinate;

        public Tuple<int, int> CurrentlyCoordinate { get { return Tuple.Create(_xCoordinate, _yCoordinate); } }

        public ChessBoard()
        {
        }

        public ChessBoard(int xCoordinate, int yCoordinate)
        {
            _chessBoard = new bool[SIZE_Board][];
            for (var i = 0; i < SIZE_Board; i++)
            {
                _chessBoard[i] = new bool[SIZE_Board];
            }
            _xCoordinate = xCoordinate;
            _yCoordinate = yCoordinate;
        }

        public int xCoordinate
        {
            get
            {
                return _xCoordinate;
            }
            set
            {
                _xCoordinate = value;
            }
        }
        public int yCoordinate
        {
            get
            {
                return _yCoordinate;
            }
            set
            {
                _yCoordinate = value;
            }
        }

    }
}
