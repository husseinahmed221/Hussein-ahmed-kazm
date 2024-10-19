using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class student
    {
        private string name;
        private string address;
        private double mark;

        public string Name

        {
            get { return name; }
            set { name = value; }

        }

        public string Address
        {

            get { return address; }
            set { address = value; }

        }

        public double Mark
        {

            get { return mark; }
            set { mark = value; }

        }

        static void Main(string[] args)
        {
            student obj = new student();
            obj.Name = "hUSSEIN";
            obj.Address = "bagdad";
            obj.Mark = 90.99;
            Console.WriteLine(" my name :" + obj.Name);
            Console.WriteLine(" my Adress:" + obj.Address);
            Console.WriteLine(" MARK:" + obj.Mark);
            Console.ReadLine();
        
        }
        }
    }

