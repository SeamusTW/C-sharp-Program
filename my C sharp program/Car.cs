using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// WEEK ONE
namespace my_C_sharp_program
{
    
       
     class Car
     {
        private string _modelName; //private variables, inaccessible outside of class
        private string _color;    
        public enum Colors //preset colors
        {
        
            red,blue ,green 

        }
        public Car(string modelName,Colors colors) //class constructor
        {
            this._modelName = modelName;
            this._color = Convert.ToString(colors);
        }
        public enum CarAttributes //car attribs
        {
        
            model = 1,
            color = 2,
            owner = 3

        }
        public string returnPrivateParameters(CarAttributes carAttribs) //switch function that returns a attrib
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
        public void PrintInfo() //prints out general info
        {
            Console.WriteLine("model:" + returnPrivateParameters(CarAttributes.model));
            Console.WriteLine("color:" + returnPrivateParameters(CarAttributes.color));
        }
     

     }

     
        
            
        


    
}
