using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibraryTesting
{
    [TestClass]
    public class HiraganaTests
    {
        [TestMethod]
        public void RandomChars_outOfBounds_returnNull()
        {
            //Arrange
            HiraganaCharacters hiragana = new HiraganaCharacters();

            //Act
            var result1 = hiragana.getRandomChars(47);
            var result2 = hiragana.getRandomChars(-5);

            //Assert
            Assert.IsNull(result1);
            Assert.IsNull(result2);
        }

        [TestMethod]
        public void RandomChars_inRange_returnStringOfSizeN()
        {
            //Arrange
            HiraganaCharacters hiragana = new HiraganaCharacters();

            //Act
            var result = hiragana.getRandomChars(46);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count == 46);
        }

        [TestMethod]
        public void SetDifficulty_DecreaseDifficulty_ExpectDecreasingAmountOfEntries()
        {
            //Arrange
            HiraganaCharacters hiragana = new HiraganaCharacters();

            //Act and Assert
            hiragana.setDifficulty(4);
            Assert.IsTrue(hiragana.getRandomChars(40).Count == 40);
            Assert.IsNull(hiragana.getRandomChars(46));
            hiragana.setDifficulty(2);
            Assert.IsNull(hiragana.getRandomChars(22));
            Assert.IsTrue(hiragana.getRandomChars(20).Count == 20);
            hiragana.setDifficulty(-5);
            Assert.IsTrue(hiragana.getRandomChars(10).Count == 10);

        }
    }
}
