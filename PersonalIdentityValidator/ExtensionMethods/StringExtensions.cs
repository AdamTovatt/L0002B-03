using System.Linq;
using System.Collections.Generic;

namespace PersonalIdentityValidator.ExtensionMethods
{
    public static class StringExtensions
    {
        public static int GetLuhnCheckDigit(this string numberData) //exentsion method för att räkna ut kontrollsiffra enligt luhns algoritm
        {
            List<char> numericChars = numberData.Where(c => char.IsNumber(c)).ToList(); //tar de tecken som är siffror

            int sum = 0;
            for (int i = 0; i < numericChars.Count; i++)
            {
                sum += ((int)char.GetNumericValue(numericChars[i]) * (2 - (i % 2))).DigitSum(); //lägger ihop siffersumman av siffrorna där varannan multipliceras med 1 och varannan multipliceras med 2
            }

            return (10 - (sum % 10)) % 10; // tar 10 - entalssiffran i summan och kollar om den är delbar på 10
        }
    }
}
