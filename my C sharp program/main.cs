using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using my_C_sharp_program;
namespace my_C_sharp_program
{

    class main
    {

        static void Main()
        {

            Car MyCar = new Car("Ford", Car.Colors.red);
            MyCar.PrintInfo();
            Console.ReadLine();
        
        }
           
        


    }
}
