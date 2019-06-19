using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace CarClass
{  

    class Car
    {

        public float GasLevel { get; set; } 
        public float FillUpAmount { get; set; }
        public float NewGasLevel { get; set; }
        public float MaxGas = 13;

        public Car()
        {
            GasLevel = RandomGasLevel();
            FillUpAmount = FillUp();
            NewGasLevel = AddGas(5);


            float RandomGasLevel()
            {
                float randomGasLevel = new Random().Next(0, 13);
                float GasLevel = randomGasLevel;
                return GasLevel;
            }


            float FillUp()
            {
                float fillupamount = MaxGas - GasLevel;
                float FillUpAmount = fillupamount;
                return FillUpAmount;
            }

            float AddGas(float gasadded)
            {

                float newGasLevel = GasLevel + gasadded;
                float NewGasLevel = newGasLevel;
                return NewGasLevel;

            }
        
        }        
    }
    
     class Program
    {
        public static void Main(string[] args)
        {
            Car myCar = new Car();


        }
    }
}
