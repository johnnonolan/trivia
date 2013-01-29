using System;
using NUnit.Framework;
using UglyTrivia;

namespace Triviatests
{
	[TestFixture()]
	public class GameTests
	{

		private Game _game;

		[SetUp]
		public void SetUp ()
		{
			_game = new Game();
		}

		[Test]
		public void WhenFindingAnAnswerOfAGameWithNoPlayersThenThrowsAnArgumentOutOfIndexException ()
		{
			Assert.Throws<ArgumentOutOfRangeException>(() =>  _game.wasCorrectlyAnswered());
		}


		[Test]
		public void WhenFindingAnAnswerOfAGameWithOutARollThenAnswerIsTrue ()
		{	
			_game.add("john");
			Assert.That(_game.wasCorrectlyAnswered(),Is.EqualTo(true));
		}


		[Test] 
		public void WhenRollingA1AnswerWasCorrect()
		{
			_game.add("john");
			_game.roll(1);
			Assert.That(_game.wasCorrectlyAnswered(),Is.EqualTo(true));
		}

		/// <summary>
		/// note at this point I realise something
		/// </summary>
		[Test] 
		public void WhenRollingA2AnswerWasCorrect()
		{
			_game.add("john");
			_game.roll(2);
			Assert.That(_game.wasCorrectlyAnswered(),Is.EqualTo(true));
		}

	}
}

