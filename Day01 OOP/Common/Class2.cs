using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    #region Encapsulation

    struct Point
    {
        #region Atrribute

        public int x;
        public int y;

        #endregion
        #region Constructors
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;

        }
        public Point()
        {

        }
        #endregion

        #region Method
        public override string ToString()
        {
            return $"({x} , {y})";
        }
        #endregion
    }
    #endregion


    struct phoneBook
    {
        string[] names;
        long[] numbers;
        int size;

        public phoneBook(int _size)
        {
            size = _size;
            names = new string[size];
            numbers = new long[size];
        }
        public int Size(int _size)
        {
            return size;
        }

        public void AddPerson(int position, string name ,long number)
        {
            if (names  is not null && numbers is not null)
            {
                if (position < size)
                {
                    names[position] = name;
                    numbers[position] = number;
                }
            }
        }

        public long GetNumber(string name)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                        return numbers[i];
                        
                    }
                }
            }
            return -1;
        }

        public  void SetNumber(string name, long newNum)
        {
            if (names is not null && numbers is not null)
            {
                for (int i = 0; i < names.Length; i++)
                {
                    if (name == names[i])
                    {
                         numbers[i]= newNum;
                        return;

                    }
                }
            }
        }
    }
   
}
