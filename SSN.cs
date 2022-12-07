using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    public class SSN
    {
        public string Number { get; init; }
        public SSN()
        {
            Number = GenerateInvalidSSN();
        }
        public string GenerateInvalidSSN()
        {
            string invalidSSN = String.Empty;
            Random random = new Random(); 

            var nineHundredSeries = random.Next(900,1000).ToString(); 
            var firstThreeArray = new string[] { "000", "666", nineHundredSeries };
            var firstThree = firstThreeArray[random.Next(3)]; 
            var secondTwo = "00";
            var lastFour = "0000";
            invalidSSN = string.Concat(firstThree, secondTwo, lastFour);
            return invalidSSN;
        }

        public override string ToString()
        {
            string socialSecurityNumber = Number;
            socialSecurityNumber = socialSecurityNumber.Insert(3, "-");
            socialSecurityNumber = socialSecurityNumber.Insert(6, "-");
            return socialSecurityNumber;
        }
    }
}
