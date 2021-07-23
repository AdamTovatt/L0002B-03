using PersonalIdentityValidator.ExtensionMethods;
using System;
using System.Linq;

namespace PersonalIdentityValidator
{
    public class Person
    {
        public string FirstName { get; private set; } //personens förnamn
        public string Surname { get; private set; } //personens efternamn
        public Gender Gender { get { return char.GetNumericValue(PersonalIdentityNumber[PersonalIdentityNumber.Length - 2]) % 2 == 0 ? Gender.Female : Gender.Male; } } //personens kön
        public string PersonalIdentityNumber { get { if (_personalIdentityNumber == null) _personalIdentityNumber = CalculatePersonalIdentityNumber(); return _personalIdentityNumber; } } //personens personnummer
        private string _personalIdentityNumber; //privat fält för den publika propertyn PersonalIdentityNumber som håller värdet när det räknats ut så det bara behöver räknas ut en gång och bara räknas ut först när man faktiskt behöver det
        public string RawNumberData { get { return _rawNumberData; } set { _rawNumberData = value; _checkSum = -1; _personalIdentityNumber = null; } } //tar bort det eventuellt uträknade personnummret om man sätter denna property, samma för checksumma. För att det inte ska kunna råka bli fel
        private string _rawNumberData; //privat fält för RawNumberdata
        public int CheckSum { get { if (_checkSum == -1) _checkSum = CalculateCheckSum(); return _checkSum; } }
        private int _checkSum = -1; //kontrollsiffran för personnummret, också gjort så det bara räknas ut en gång och sen sparas
        public bool ValidCheckSum { get { return CheckSum == char.GetNumericValue(PersonalIdentityNumber.Last()); } } //property för att säga om kontrollsiffran är giltig

        private Person() { } //privat konstruktor. Den är privat för att man inte ska kunna råka skapa en instans av klassen på felaktigt sätt då den alltid ska skapas genom den statiska Create() funktionen

        public static Person Create(string identityNumber, string firstName, string surname) //funktion för att skapa en person, måste användas för att skapa en person vilket säkerställer att personen blir rätt skapad och om den inte kan skapas rätt kastar den ett fel
        {
            if (string.IsNullOrEmpty(identityNumber)) //vi kan inte skapa ett personnummer från en tom sträng
                throw new Exception("Kan inte skapa ett personnummer från en sträng som är tom eller null");

            string onlyDigits = identityNumber.Replace("-", "").Replace("+", ""); //tar bort eventuella + och - från personnummret

            if (!onlyDigits.All(c => char.IsDigit(c))) //kollar att resterande tecken faktiskt bara är siffror vilket innebär att personnummret bara har siffror och/eller - och +
                throw new Exception(string.Format("Ett personnummer kan endast inehålla \"-\", \"+\" och siffror (misslyckades för {0})", identityNumber));

            if (identityNumber.Contains('-') && identityNumber.IndexOf('-') != identityNumber.Length - 5) //kollar att positionen för - är korrekt
                throw new Exception(string.Format("Ett personnummer kan endast inehålla \"-\" på en position som är precis före de fyra sista siffrorna"));

            if (identityNumber.Contains('+') && identityNumber.IndexOf('+') != identityNumber.Length - 5) //kollar att positionen för + är korrekt. I svenska personnummer används + istället för - i den 10 siffriga formen om personen är över 100 år, det är därför vi måste ha med detta
                throw new Exception(string.Format("Ett personnummer kan endast inehålla \"+\" på en position som är precis före de fyra sista siffrorna"));

            if (onlyDigits.Length != 10 && onlyDigits.Length != 12) //kontrollerar att längden stämmer
                throw new Exception(string.Format("Ett personnummer måste ha en längd som är 10 eller 12 (misslyckades för {0})", identityNumber));

            return new Person() //skapar en ny person
            {
                RawNumberData = identityNumber, //vi sparar "RawNumberData" för att det kan vara bra att ha orginaldatan för eventuella felmeddelanden eller debugging, jobbigt om bara en modifierad version skulle sparas, därför sparas orginalet och sen räknas den modifierade ut när man behöver den (detta sparar också potentiellt tid på cpu då det aldrig kommer räknas ut i onödan, man säger att propertyn är "lat")
                FirstName = firstName,
                Surname = surname,
            };
        }

        protected string CalculatePersonalIdentityNumber() //metod för att räkna ut personens personnummer från RawNumberData
        {
            string onlyDigits = RawNumberData.Replace("-", "").Replace("+", "");
            return onlyDigits.Length == 10 ? onlyDigits : onlyDigits.Substring(2, 10); //vi tar bara de 10 sista siffrorna
        }

        protected int CalculateCheckSum() //metod för att räkna ut personnummrets kontrollsiffra
        {
            return PersonalIdentityNumber.Substring(PersonalIdentityNumber.Length - 10, 10).Substring(0, 9).GetLuhnCheckDigit(); //tar de sista 10 siffrorna i personnummret och använder en extension method för att räkna ut kontrollsiffran. Det är en extension method för jag tycker inte den metoden bör vara på personobjektet då det egentligen inte är en egenskap av en person
        }
    }
}
