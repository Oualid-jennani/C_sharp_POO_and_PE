using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Person
    {
        public void showMsg()
        {
            Console.WriteLine("I'm Person");
        }
        // عرفنا وظيفة الوورك بأنها ستكون مشابهة لعملها بكلاس موروث عن طريق الكلمة فيرتشوال
        virtual public void Work()
        {
            Console.WriteLine("I Work");
        }
    }
    class Programmerrrr:Person
    {
        // عند كتابة اوفروايد وربطها بوظيفة في الكلاس الرئيسي سياخذ عناصر الوظيفة التي في الكلاس الرئيسي بالإضافة الى الوظيفة المربوطة بها من الكلاس البنت
        public override void Work()
        {
            // Message from Main Class "Person"
            base.Work();
           
            //Message from Drived Class "Programmer"
            Console.WriteLine("I'm a Programmer");
        }
    }

    class Doctor:Person
    {
        // استخدمنا نيو
       new public  void Work()
        {
      
            //Message from Drived Class "Programmer"
            Console.WriteLine("\n\nI'm a Doctor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Programmerrrr pro = new Programmerrrr();
            pro.Work();

            Doctor doct = new Doctor();
            doct.Work();
            
            Console.ReadKey();
        }
    }
}﻿