using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace my_C_sharp_program
{
    
       
     class Car
     {
        private string _modelName;
        private string _color;    
        public enum Colors
        {
        
            red,blue ,green 

        }
        public Car(string modelName,Colors colors)
        {
            this._modelName = modelName;
            this._color = Convert.ToString(colors);
        }
        public enum CarAttributes
        {
        
            model = 1,
            color = 2,
            owner = 3

        }
        public string returnPrivateParameters(CarAttributes carAttribs)
        {
            
            switch (Convert.ToInt32(carAttribs))
            {
               case 1:
                    return _modelName;
                    
               case 2:
                    return _color;
                   
            }
            return "null";

        }
        public void PrintInfo()
        {
            Console.WriteLine("model:" + returnPrivateParameters(CarAttributes.model));
            Console.WriteLine("color:" + returnPrivateParameters(CarAttributes.color));
        }
        static void Main()
        {

            Car MyCar = new Car("Ford",Colors.red);
            Console.Write(MyCar._color);
            Console.ReadLine();

        }

     }

     
        
            
        


    
}
