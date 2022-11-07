using SirenSiretApp.Model;

namespace SirenSiretAppTest
{
    public class InputTest
    {
        [Theory]
        [InlineData("")]
        [InlineData("1232")]
        [InlineData("321321321321321")]
        public void CheckInputLength_ShouldReturnFalse(string s)
        {
            //Arrange
            Input _input = new Input();
            //Act
            bool result = _input.CheckInputLength(s);
            //Assert
            Assert.False(result);
        }

        [Theory]
        [InlineData("012587485")]
        [InlineData("01258748521548")]
        [InlineData("         ")]
        public void CheckInputLength_ShouldReturnTrue(string s)
        {
            //Arrange
            Input _input = new Input();
            //Act
            bool result = _input.CheckInputLength(s);
            //Assert
            Assert.True(result);
        }

        [Theory]
        [InlineData("")]
        [InlineData("asjh2132d")]
        [InlineData("1232684651321651321651")]
        [InlineData("-651321651")]
        [InlineData("   6513 21651 ")]
        public void CheckParsing_ShouldReturnFalse(string s)
        {
            Input _input = new Input();
            _input.userInputstr = s;
            bool result = _input.CheckParsing();
            Assert.False(result);
        }

        [Theory]
        [InlineData("6513218")]
        [InlineData("6")]
        [InlineData("    21651")]
        [InlineData("21651      ")]
        public void CheckParsing_ShouldReturnTrue(string s)
        {
            Input _input = new Input();
            _input.userInputstr = s;
            bool result = _input.CheckParsing();
            Assert.True(result);
        }

        [Theory]
        [InlineData("800403222")]
        [InlineData("80040322200014")]
        [InlineData("217103746")]
        [InlineData("800403223")]
        [InlineData("80040322200015")]
        [InlineData(" 800403223")]
        public void CheckGlobalCorrect_ShouldReturnTrue(string s)
        {
            Input _input = new Input();
            _input.userInputstr = s;
            bool result = _input.CheckGlobalCorrect();
            Assert.True(result);
        }

        [Theory]
        [InlineData("800432130322200014")]
        [InlineData("-651321651")]
        [InlineData("   6513 21651 ")]
        [InlineData("")]
        [InlineData("840v22")]
        [InlineData("   840222")]
        public void CheckGlobalCorrect_ShouldReturnFalse(string s)
        {
            Input _input = new Input();
            _input.userInputstr = s;
            bool result = _input.CheckGlobalCorrect();
            Assert.False(result);
        }

        [Theory]
        [InlineData("80040322200015")]
        [InlineData("800403223")]
        public void KeyLhunAlgorithm_ShouldReturnFalse(string s)
        {
            Input _input = new Input();
            _input.userInputstr = s;
            bool result = _input.KeyLhunAlgorithm();
            Assert.False(result);
        }

        [Theory]
        [InlineData("800403222")]
        [InlineData("80040322200014")]
        [InlineData("217103746")]
        public void KeyLhunAlgorithm_ShouldReturnTrue(string s)
        {
            Input _input = new Input();
            _input.userInputstr = s;
            bool result = _input.KeyLhunAlgorithm();
            Assert.True(result);
        }
    }
}