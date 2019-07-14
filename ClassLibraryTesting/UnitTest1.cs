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

        [TestMethod]
        public void getKeyByValue_nonexistingKey_returnsNull()
        {
            //Arrange
            HiraganaCharacters hiragana = new HiraganaCharacters();

            //Act
            var result = hiragana.getKeyByValue("く");

            //Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void getKeyByValue_existingKey_returnsProperValue()
        {
            //Arrange
            HiraganaCharacters hiragana = new HiraganaCharacters();

            //Act
            var result = hiragana.getKeyByValue("ku");

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result, "く");
        }

        [TestMethod]
        public void getValueByKey_nonExistingValue_returnsNull()
        {
            HiraganaCharacters hiragana = new HiraganaCharacters();

            //Act
            var result = hiragana.getValueByKey("ku");

            //Assert
            Assert.IsNull(result);
        }

        [TestMethod]
        public void getValueByKey_ExistingValue_returnsKey()
        {
            //Arrange
            HiraganaCharacters hiragana = new HiraganaCharacters();

            //Act
            var result = hiragana.getValueByKey("く");

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(result, "ku");
        }

        [TestMethod]
        public void compareKeyAndValue_correctComparison_returnsTrue()
        {
            //Arrange
            HiraganaCharacters hiragana = new HiraganaCharacters();

            //Act

            var result = hiragana.compareKeyAndValue("も", "mo");

            //Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void compareKeyAndValue_incorrectComparison_returnsFalse()
        {
            //Arrange
            HiraganaCharacters hiragana = new HiraganaCharacters();

            //Act

            var result = hiragana.compareKeyAndValue("も", "moada");

            //Assert
            Assert.IsNotNull(result);
            Assert.IsFalse(result);
        }
    }
}
