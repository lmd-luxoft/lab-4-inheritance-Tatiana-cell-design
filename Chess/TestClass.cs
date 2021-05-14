// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;

namespace Chess
{
    [TestFixture]
    public class TestClass
    {

        [Test]
        public void RookShouldBeCorrectMove()
        {
            ChessFigure figure = new ChessFigure("E2", new MoveRook());
            Assert.AreEqual(true, figure.MoveTo("C2"));
        }

        [Test]
        public void RookShouldBeIncorrectMove()
        {
            ChessFigure figure = new ChessFigure("E2", new MoveRook());
            Assert.AreEqual(false, figure.MoveTo("C5"));
        }


        [Test]
        public void KnightShouldBeCorrectMove()
        {
            ChessFigure figure = new ChessFigure("B1", new MoveKnight());
            Assert.AreEqual(true, figure.MoveTo("C3"));
        }

        [Test]
        public void KnightShouldBeIncorrectMove()
        {
            ChessFigure figure = new ChessFigure("B1", new MoveKnight());
            Assert.AreEqual(false, figure.MoveTo("C5"));
        }

        [Test]
        public void BishopShouldBeCorrectMove()
        {
            ChessFigure figure = new ChessFigure("C1", new MoveBishop());
            Assert.AreEqual(true, figure.MoveTo("E3"));
        }

        [Test]
        public void BishopShouldBeIncorrectMove()
        {
            ChessFigure figure = new ChessFigure("C1", new MoveBishop());
            Assert.AreEqual(false, figure.MoveTo("E3"));
        }

        [Test]
        public void PawnShouldBeCorrectMove0()
        {
            ChessFigure figure = new ChessFigure("E2", new MovePawn());
            Assert.AreEqual(true, figure.MoveTo("E3"));
        }

        [Test]
        public void PawnShouldBeCorrectMove1()
        {
            ChessFigure figure = new ChessFigure("E2", new MovePawn());
            Assert.AreEqual(true, figure.MoveTo("E4"));
        }
        [Test]
        public void PawnShouldBeCorrectMove2()
        {
            ChessFigure figure = new ChessFigure("E4", new MovePawn());
            Assert.AreEqual(true, figure.MoveTo("E5"));
        }
        [Test]
        public void PawnShouldBeIncorrectMove()
        {
            ChessFigure figure = new ChessFigure("E2", new MovePawn());
            Assert.AreEqual(false, figure.MoveTo("C5"));
        }

        [Test]
        public void KingShouldBeCorrectMove()
        {
            ChessFigure figure = new ChessFigure("E1", new MoveKing());
            Assert.AreEqual(true, figure.MoveTo("E2"));
        }
        [Test]
        public void KingShouldBeIncorrectMove()
        {
            ChessFigure figure = new ChessFigure("E1", new MoveKing());
            Assert.AreEqual(false, figure.MoveTo("E8"));
        }
        [Test]
        public void QueenShouldBeCorrectMoveVertical()
        {
            ChessFigure figure = new ChessFigure("D1", new MoveQueen());
            Assert.AreEqual(true, figure.MoveTo("D8"));
        }
        [Test]
        public void QueenShouldBeCorrectMoveDiagonal()
        {
            ChessFigure figure = new ChessFigure("D1", new MoveQueen());
            Assert.AreEqual(true, figure.MoveTo("H5"));
        }
        [Test]
        public void QueenShouldBeIncorrectMove()
        {
            ChessFigure figure = new ChessFigure("D1", new MoveQueen());
            Assert.AreEqual(false, figure.MoveTo("E3"));

        }
    }
}
