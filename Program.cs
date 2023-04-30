using FactoryMethodPattern_Project.Controllers;
using FactoryMethodPattern_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IObjectFactory factory = new ObjectFactory();
            TestController controller = new TestController(factory);
            controller.Action();
            Console.ReadLine();

        }
    }
}
