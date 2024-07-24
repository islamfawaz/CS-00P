namespace Assignment
{



    [Flags]
    enum WeekDays : byte
    {
        Saturday = 1,
        Sunday = 2,
        Monday = 4,
        Tuesday = 8,
        Wednesday = 16,
        Thursday = 32,
        Friday = 64
    }


    public struct Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }


    [Flags]
    enum Permissions : byte
    {
        Read = 1,       // Binary: 0001
        Write = 2,      // Binary: 0010
        Delete = 4,     // Binary: 0100
        Execute = 8
    }



    enum Colors
    {
        Red,
        Green,
        Blue
    }


    struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Point(double _x, double _y)
        {
            X = _x;
            Y = _y;
        }
        public static double Distance(Point p1, Point p2)
        {
            double distanceX = p1.X - p2.X;
            double distanceY = p1.Y - p2.Y;
            return Math.Sqrt(distanceX * distanceX + distanceY * distanceY);
        }
    }


    struct Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person2(string _name, int _age)
        {
            Name = _name;
            Age = _age;
        }
    }


    internal class Program
    {

        static void Main(string[] args)
        {
            #region Question1
            //1 Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members.
            //Then, write a C# program that prints out all the days of the week using this enum.
            //WeekDays daysSum = WeekDays.Saturday | WeekDays.Sunday | WeekDays.Monday | WeekDays.Tuesday | WeekDays.Wednesday | WeekDays.Thursday | WeekDays.Friday;
            //Console.WriteLine(daysSum);
            #endregion

            #region Question2
            //2 Define a struct "Person" with properties "Name" and "Age".
            //Create an array of three "Person" objects and populate it with data. Then,
            //write a C# program to display the details of all the persons in the array.

            //Person[] persons = new Person[3];
            //persons[0].Name = "islam";
            //persons[0].Age = 21;

            //persons[1].Name = "ahmed";
            //persons[1].Age = 44;

            //persons[2].Name = "fawaz";
            //persons[2].Age = 25;
            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine($"Name: {persons[i].Name}, Age: {persons[i].Age}");
            //}


            #endregion

            #region Question3
            //3 Create an enum called "Seas on" with the four seasons (Spring, Summer, Autumn, Winter) as its members.
            //Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Season InputSeason;

            //do
            //{
            //    Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //    string input = Console.ReadLine();

            //     if (Enum.TryParse(input, true, out  InputSeason))
            //    {
            //        break; 
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid season.");
            //    }
            //} while (true);

            //switch (InputSeason)
            //{
            //    case Season.Spring:
            //        Console.WriteLine("Spring: March to May");
            //        break;
            //    case Season.Summer:
            //        Console.WriteLine("Summer: June to August");
            //        break;
            //    case Season.Autumn:
            //        Console.WriteLine("Autumn: September to November");
            //        break;
            //    case Season.Winter:
            //        Console.WriteLine("Winter: December to February");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid season.");
            //        break;
            #endregion

            //  }


            #region Question4
            // 4 Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.

            //Permissions UserPermissions = Permissions.Read | Permissions.Write;

            //UserPermissions |= Permissions.Execute;

            //UserPermissions &= ~Permissions.Write;

            //UserPermissions |= Permissions.Delete;


            //if ((UserPermissions & Permissions.Delete) != 0)
            //{
            //    Console.WriteLine("User has Delete permission.");
            //}
            //else
            //{
            //    Console.WriteLine("User does not have Delete permission.");
            //}
            #endregion


            #region Question5
            //5 Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members.
            //Write a C# program that takes a color name as input from the user and
            //displays a message indicating whether the input color is a primary color or not.
            //    Console.WriteLine("Enter a color name:");
            //    string inputColor = Console.ReadLine();

            //    if (Enum.TryParse(inputColor, true, out Colors color))
            //    {
            //        if (IsPrimaryColor(color))
            //        {
            //            Console.WriteLine($"{inputColor} is a primary color.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"{inputColor} is not a primary color.");
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid input. Please enter a valid color name (Red, Green, Blue).");
            //    }
            //}        private static bool IsPrimaryColor(Colors color)
            //{
            //    return color == Colors.Red || color == Colors.Green || color == Colors.Blue;
            //}
            #endregion

            #region Question6


            //Console.WriteLine("Enter coordinates for Point  (X1 Y1):");
            //string[] inputNum1 = Console.ReadLine().Split();
            //double x1 = double.Parse(inputNum1[0]);
            //double y1 = double.Parse(inputNum1[1]);

            //Console.WriteLine("Enter coordinates for Point  (X2 Y):");
            //string[] inputNum2 = Console.ReadLine().Split();
            //double x2 = double.Parse(inputNum2[0]);
            //double y2 = double.Parse(inputNum2[1]);

            //Point point1 = new Point(x1, y1);
            //Point point2 = new Point(x2, y2);


            //double distance = Point.Distance(point1, point2);


            //Console.WriteLine($"Distance between  ({point1.X}, {point1.Y}) and ({point2.X}, {point2.Y}): {distance}");
            #endregion

            #region Question7
            //    Person2[] persons = new Person2[3];

            //    for (int i = 0; i < persons.Length; i++)
            //    {
            //        Console.WriteLine($"Enter details {i + 1}:");
            //        Console.Write("Name: ");
            //        string name = Console.ReadLine();
            //        Console.Write("Age: ");
            //        int age = int.Parse(Console.ReadLine());
            //        persons[i] = new Person2(name, age);
            //    }

            //    Person2 oldestPerson = FindOldest(persons);

            //    Console.WriteLine($"The oldest person is {oldestPerson.Name} with age {oldestPerson.Age}.");
            //}

            // private static Person2 FindOldest(Person2[] persons)
            //{
            //    Person2 oldestPerson = persons[0];

            //    for (int i = 1; i < persons.Length; i++)
            //    {
            //        if (persons[i].Age > oldestPerson.Age)
            //        {
            //            oldestPerson = persons[i];
            //        }
            //    }

            //    return oldestPerson;
            #endregion
        }
    }
}




