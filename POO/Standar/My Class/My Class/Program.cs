using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        int ID;
        string COLOR;
        string MODEL;
        public void initialize(int id, string color, string model)
        {
            ID = id;
            COLOR = color;
            MODEL = model;
        }
        public void shewdetails()
        {
            Console.WriteLine("ID is :{0}\nCOLOR is :{1}\nMODEL is :{2}", ID, COLOR, MODEL);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Car mycar = new Car();
            mycar.initialize(10, "bleu", "ér quat");
            mycar.shewdetails();
            Console.ReadKey();
        }
    }
}
