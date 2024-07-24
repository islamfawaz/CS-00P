using Assignment.Classes;
using System.Collections.Immutable;

namespace Assignment
{
    internal class Program
    {

        static Point3D ReadPoint(string PointName)
        {
            int x = ReadCoordinate($"{PointName} X");
            int y = ReadCoordinate($"{PointName} Y");
            int z = ReadCoordinate($"{PointName} Z");

            return new Point3D(x, y, z);
        }



        static int ReadCoordinate(string coordinateName)
        {
            int result;
            string input;

            do
            {
                Console.Write($"Enter {coordinateName} coordinate: ");
                input = Console.ReadLine();

                if (int.TryParse(input, out result))
                {
                    return result;
                }

                result = Convert.ToInt32(input);
                return result;

                Console.WriteLine("Invalid input");
            } while (true);
        }




        static void Main(string[] args)
        {
            #region First Project:

            //Point3D P = new Point3D(10,10,10);
            //Console.WriteLine(P.ToString());
            //Point3D P1 = ReadPoint("P1");
            //Point3D P2 = ReadPoint("P2");
            //Point3D P3 = ReadPoint("P3");

            //Console.WriteLine($"Point P1: {P1}");
            //Console.WriteLine($"Point P2: {P2}");
            //Console.WriteLine($"Point P3: {P3}");

            // doesnt work  need to override
            //after override its work
            //if (P1 == P2)
            //{
            //    Console.WriteLine("p1 equal p2");
            //}
            //else
            //{
            //    Console.WriteLine("doesnt work");

            //}

            //Point3D[] arr = { P1, P2, P3 };
            //Array.Sort(arr);
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("Sorted Array"+arr[i]);

            //}
            #endregion


            #region Second Project
            //Console.WriteLine(Maths.Mult(5, 2));

            //Console.WriteLine(Maths.Subtract(5,3));
            //Console.WriteLine(Maths.Add(5,2));
            //Console.WriteLine(Maths.Divide(5, 0));

            #endregion

            #region Third project

            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString());


            #endregion

            #region Fourth project
            Duration D3 = D1 + D2;

            D3++;
            Console.WriteLine(D3.ToString());

            if (D1 > D2)
            {
                Console.WriteLine("D1 is greater than D2");
            }
            #endregion
        }


    }
}

