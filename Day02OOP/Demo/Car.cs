using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Car
    {

        private int id;
        private string? Model;
        private decimal speed;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        public string? model
        {
            get { return Model; }
            set { Model = value; }
        }
        public decimal Speed
        {
            get { return speed; }
            set { speed = value; }
        }


        public Car(int _id ,string _model ,decimal _speed)
        {
            id = _id;   
            Model = _model;
            Speed = _speed;
            Console.WriteLine("Ctr01");
        }

        public Car(int _id, string _model):this(_id ,_model,180 )
        {
            //id = _id;
            //Model = _model;
            //speed = 180;
            Console.WriteLine("Ctr02");

        }


        public Car(int _id) : this(_id,"chery")
        {
            //id = _id;
            //Model = _model;
            //speed = 180;
            Console.WriteLine("Ctr03");

        }


        public override string ToString()
        {
            return $"Car Id :{id}\nModel : {model}\nSpeed : {speed}";
        }



    }
}
