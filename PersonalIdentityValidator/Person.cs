using PersonalIdentityValidator.ExtensionMethods;
using System;
using System.Linq;

namespace PersonalIdentityValidator
{
    public class Person
    {
        public string FirstName { get; private set; }
        public string Surname { get; private set; }
        public Gender Gender { get { return char.GetNumericValue(PersonalIdentityNumber[PersonalIdentityNumber.Length - 2]) % 2 == 0 ? Gender.Male : Gender.Female; } }
        public string PersonalIdentityNumber { get { if (_personalIdentityNumber == null) _personalIdentityNumber = CalculatePersonalIdentityNumber(); return _personalIdentityNumber; } }
        private string _personalIdentityNumber;
        public string RawNumberData { get { return _rawNumberData; } set { _rawNumberData = value; _checkSum = -1; _personalIdentityNumber = null; } }
        private string _rawNumberData;
        public int CheckSum { get { if (_checkSum == -1) _checkSum = CalculateCheckSum(); return _checkSum; } }
        private int _checkSum = -1;

        private Person() { }

        public static Person Create(string identityNumber, string firstName, string surname)
        {
            if (string.IsNullOrEmpty(identityNumber))
                throw new Exception("Can not create a valid IdentityNumber from a string that is null or empty");

            string onlyDigits = identityNumber.Replace("-", "").Replace("+", "");

            if (!onlyDigits.All(c => char.IsDigit(c)))
                throw new Exception(string.Format("An IdentityNumber can only contain \"-\", \"+\" and digits (failed for {0})", identityNumber));

            if (identityNumber.Contains('-') && identityNumber.IndexOf('-') != identityNumber.Length - 5)
                throw new Exception(string.Format("An IdentityNumber can only contain \"-\" in a position that is immediately before the 4 last digits"));

            if (identityNumber.Contains('+') && identityNumber.IndexOf('+') != identityNumber.Length - 5)
                throw new Exception(string.Format("An IdentityNumber can only contain \"+\" in a position that is immediately before the 4 last digits"));

            if (onlyDigits.Length != 10 && onlyDigits.Length != 12)
                throw new Exception(string.Format("An IdentityNumber must have a length of either 12 or 10 (failed for {0})", identityNumber));

            string tenDigits = onlyDigits.Length == 10 ? onlyDigits : onlyDigits.Substring(2, 10);

            return new Person()
            {
                RawNumberData = identityNumber,
                FirstName = firstName,
                Surname = surname,
            };
        }

        protected string CalculatePersonalIdentityNumber()
        {
            string onlyDigits = RawNumberData.Replace("-", "").Replace("+", "");
            return onlyDigits.Length == 10 ? onlyDigits : onlyDigits.Substring(2, 10);
        }

        protected int CalculateCheckSum()
        {
            return PersonalIdentityNumber.Substring(PersonalIdentityNumber.Length - 10, 10).Substring(0, 9).GetLuhnCheckDigit();
        }
    }
}
