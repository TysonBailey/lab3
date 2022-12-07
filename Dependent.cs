using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RandomDataGenerator
{
    public class Dependent : Person
    {
        public Dependent()
        {
            Random rand = new Random();
            

            var lastArray = RandomDataGenerator.LastName.GetValues(typeof(LastName));
            var value = (LastName)lastArray.GetValue(rand.Next(lastArray.Length));
            this.LastName = value.ToString();

            DateTime dateToday = DateTime.Now;

            int year = rand.Next(dateToday.Year + 10);
            int month = rand.Next(1, 12);
            int day = rand.Next(1, 31);

            BirthDate = new DateTime(year, month, day);

            this.SSN = new SSN();

            this.Phone = new Phone();

        }

    }
}

