using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLib;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Driver driver = new Driver();

            driver.OperateCar();

            //Car car = new Car(); - not available out of the classlib project
        }
    }
}
