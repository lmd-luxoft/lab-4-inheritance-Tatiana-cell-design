
using System;

namespace Chess
{
    public class ChessFigure
    {
        private string currentCoord;
        public IMoveFigure FavoriteMoveFigure { get; private set; }

        public ChessFigure(string currentCoord,
                            IMoveFigure favoriteMoveFigure)

        {
            this.currentCoord = currentCoord;
            FavoriteMoveFigure = favoriteMoveFigure;

        }

        /*      public enum Type
			  {ROOK,KNIGHT,BISHOP,PAWN,KING,QUEEN  }
		*/
        public bool CheckField(string nextCoord) {
               
              if (nextCoord[0] >= 'A' && nextCoord[0] <= 'H' && nextCoord[1] >= '1' && nextCoord[1] <= '8')
         
                return true;
            else
                return false;
        }
        public bool MoveTo(string nextCoord, IMoveFigure moveFigure)  
        {

            if (CheckField(nextCoord))
            {
                if (moveFigure.Move(nextCoord, currentCoord))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        public bool MoveTo(string nextCoord)
        {
            if (CheckField(nextCoord))
            {
                if (MoveTo(nextCoord, FavoriteMoveFigure))
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

    }

    public interface IMoveFigure
    {
        bool Move(string nextCoord, string currentCoord);              

    }


    public class MovePawn : IMoveFigure
    {
        public bool Move(string nextCoord, string currentCoord)     
        {
            if (nextCoord[0] != currentCoord[0] || nextCoord[1] <= currentCoord[1] || (nextCoord[1] - currentCoord[1] != 1 && (currentCoord[1] != '2' || nextCoord[1] != '4')))
                return false;
            else
                return true;
        }
    }

    public class MoveRook : IMoveFigure
    {
        public bool Move(string nextCoord, string currentCoord)        
        {
            if ((nextCoord[0] != currentCoord[0]) && (nextCoord[1] != currentCoord[1]) || ((nextCoord[0] == currentCoord[0]) && (nextCoord[1] == currentCoord[1])))
                return false;
            else
                return true;
        }
    }

    public class MoveKnight : IMoveFigure
    {
        public bool Move(string nextCoord, string currentCoord)         
        {
            int dx, dy;
            dx = Math.Abs(nextCoord[0] - currentCoord[0]);
            dy = Math.Abs(nextCoord[1] - currentCoord[1]);
            if (!(Math.Abs(nextCoord[0] - currentCoord[0]) == 1 && Math.Abs(nextCoord[1] - currentCoord[1]) == 2 || Math.Abs(nextCoord[0] - currentCoord[0]) == 2 && Math.Abs(nextCoord[1] - currentCoord[1]) == 1))
                return false;
            else
                return true;
        }
    }

    public class MoveBishop : IMoveFigure
    {
        public bool Move(string nextCoord, string currentCoord)    
        {
            if (!(Math.Abs(nextCoord[0] - currentCoord[0]) == Math.Abs(nextCoord[1] - currentCoord[1])))
                return false;
            else
                return true;
        }
    }
    public class MoveKing : IMoveFigure
    {
        public bool Move(string nextCoord, string currentCoord)          
        {
            if (!(Math.Abs(nextCoord[0] - currentCoord[0]) <= 1 && Math.Abs(nextCoord[1] - currentCoord[1]) <= 1))
                return false;
            else
                return true;
        }
    }
    public class MoveQueen : IMoveFigure
    {
        public bool Move(string nextCoord, string currentCoord)          

        {
            if (!(Math.Abs(nextCoord[0] - currentCoord[0]) == Math.Abs(nextCoord[1] - currentCoord[1]) || nextCoord[0] == currentCoord[0] || nextCoord[1] == currentCoord[1]))
                return false;
            else
                return true;
        }
    }
}
