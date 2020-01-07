using System;
using System.Linq;

namespace Prime.Services 
{
    public class Palindromo {

        public bool IsPalindromo(string value) {
            var reverseString = new string(value.Reverse().ToArray());
            return value == reverseString;
        }
    }
}