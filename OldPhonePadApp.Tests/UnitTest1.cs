using Xunit;
using OldPhonePadApp;

namespace OldPhonePadApp.Tests
{
    public class OldPhonePadTests
    {
        private readonly OldPhonePadService _service = new();

        [Theory]
        [InlineData("33#", "E")]
        [InlineData("227*#", "B")]
        [InlineData("4433555 555666#", "HELLO")]
        [InlineData("8 88777444666*664#", "TURING")]
        [InlineData("7777#", "S")]
        [InlineData("9999#", "Z")]
        [InlineData("222 2 22#", "CAB")]
        [InlineData("0#", " ")]
        public void Test_OldPhonePad(string input, string expected)
        {
            // Act
            var result = _service.Decode(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}
