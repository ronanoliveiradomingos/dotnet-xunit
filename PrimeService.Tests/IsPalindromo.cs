using Xunit;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    public class PrimeService_IsPalindromo
    {
        private readonly Prime.Services.Palindromo _primeService;

        public PrimeService_IsPalindromo()
        {
            _primeService = new Palindromo();
        }

        [Theory]
        [InlineData("OVO")]
        public void IsPalindromo(string value)
        {
            var result = _primeService.IsPalindromo(value);
            Assert.True(result, $"{value} is palindrome");
        }
        [Theory]
        [InlineData("ABCDF")]
        public void IsNotPalindromo(string value)
        {
            var result = _primeService.IsPalindromo(value);

            Assert.False(result, $"{value} is not palindrome");
        }
    }
}