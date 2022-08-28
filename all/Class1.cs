using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3Bai2
{
    internal class Class1
    {
       /* private string firstName;
        private string lastName;
        private string address;
        private long sin;
        private double salary;*/
     

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public long sin { get; set; }
        public double salary { get; set; }

        public Class1(string firstName, string lastName, string address, long sin, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.sin = sin;
            this.salary = salary;
        }
        public override string ToString()
        {
            return "Person: " + firstName + " " + 
                lastName + " " + address + " " + 
                sin + " " + salary;
        }

        public static void main(string[] args)
        {
            Console.WriteLine("Nhap thong tin nguoi dung0 \nFirst Name : ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Last Name :");
            string lastname = Console.ReadLine();
            Console.WriteLine("Address :");
            string address = Console.ReadLine();
            Console.WriteLine("sin :");
            long sin = long.Parse(Console.ReadLine());
            Console.WriteLine("salary :");
            double salary = double.Parse(Console.ReadLine());   

            Class1 c = new Class1(firstname,lastname,address,sin,salary);

            Console.WriteLine("Tien Thuong cua nhan vien do la :" + salary * sin);
        }
       
    }
}
