using RandomDataGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomDataGenerator
{
    public class Person
    {

        private string[] arrayOfFirstNames = { "Bill", "Jack", "Jill", "Will", "Jennifer", "John", "Gary", "Kelly", "James", "Samson" };
        
        private Dependent[] dependents = new Dependent[10];
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public DateTime BirthDate { get; init; }
        public SSN SSN { get; init; }
        public Phone Phone { get; init; }

        public Person()
        {
            Random rand = new Random();
            FirstName = arrayOfFirstNames[rand.Next(arrayOfFirstNames.Length)];

            var lastArray = RandomDataGenerator.LastName.GetValues(typeof(LastName));
            var value = (LastName)lastArray.GetValue(rand.Next(lastArray.Length));
            this.LastName = value.ToString();

            DateTime dateToday = DateTime.Now;

            int year = rand.Next(dateToday.Year - 81, dateToday.Year - 19);
            int month = rand.Next(1, 12);
            int day = rand.Next(1, 31);

            BirthDate = new DateTime(year, month, day);

            this.SSN = new SSN();

            this.Phone = new Phone();

        }

        public int GetAge()
        {
            var age = DateTime.Now - BirthDate;
            return age.Days / 365;
        }

        public void AddDependent()
        {
            int i = 0;
            if (dependents[i] == null)
            {
                dependents[i] = new Dependent();
                i++;
            }
            


        }
        public override string ToString()
        {
            return
                $"-----------------------------------------\n" +
                $"Name:\t\t{FirstName} {LastName}\n" +
                $"Birthday:\t{BirthDate.ToShortDateString()}\n" +
                $"Age:\t\t{GetAge()}\n" +
                $"SSN:\t\t{SSN}\n" +
                $"Phone:\t\t{Phone.Number}\n" +
                $"Dependents:\t\t{dependents[0]}{dependents[1]}{dependents[2]}{dependents[3]}{dependents[4]}{dependents[5]}{dependents[6]}{dependents[7]}{dependents[8]}{dependents[9]}\n"  +
                $"-----------------------------------------\n";
        }

        
    }
}