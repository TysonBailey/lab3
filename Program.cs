using RandomDataGenerator;

    public class Program
    {
        static List<Person> people = new List<Person>();

        public static void Main(string[] args)
        {
            var option = 0;
            do
            {
                DisplayMenu();
                option = Int32.Parse(Console.ReadLine());
                MenuChoice(option);

                Console.WriteLine("\nHit Enter to return to menu...");
                Console.ReadLine();
                Console.Clear();
            } while (option != 0);
        }
        
        public static void DisplayMenu()
        {
            Console.WriteLine("------ Menu ------");
            Console.WriteLine("1. Create a new Person");
            Console.WriteLine("2. View all people");
            Console.WriteLine("3. Remove a person");
            Console.WriteLine("4. View a last name");
            Console.WriteLine("5. Create and View Random SSN");
            Console.WriteLine("6. View a phone number");
            Console.WriteLine("0. Exit");
            Console.WriteLine("------------------");
        }

        public static void MenuChoice(int option)
        {
            Random random = new Random();
            switch (option)
            {
                
            case 1:
                    people.Add(new Person());
                    Console.WriteLine("New Person Added.");
                    break;
                
            case 2:
                if (people.Count > 0)
                {
                    foreach (Person person in people)
                    {
                        Console.WriteLine(person);
                    }
                }
                else
                {
                    people.Add(new Person());
                    foreach (Person person in people)
                    {
                        Console.WriteLine(person);
                    }
                }
                    break;
                
            case 3:
                foreach(Person person in people)
                {
                    Console.WriteLine(person);
                }
                Console.WriteLine("What person do you want to remove?\n Enter a valid index starting at 0: ");
                people.RemoveAt(int.Parse(Console.ReadLine()));
                break;
                
            case 4:
                Person person2 = people[random.Next(people.Count())];
                Console.WriteLine(person2.LastName);
                break;
                
            case 5:
                    Person person3 = people[random.Next(people.Count())];
                    Console.WriteLine(person3.SSN);
                    break;
            
            case 6:
                Console.WriteLine("What character separator would you like to use for the number?: ");
                Char newSeparator = Char.Parse(Console.ReadLine());
                Phone phone = new Phone(newSeparator);
                Console.WriteLine(phone);
                break;

            case 0:
                    Console.WriteLine("Exiting program.");
                    break;
                default:
                    Console.WriteLine("Input a valid choice.");
                    break;
            }
        }
    }
