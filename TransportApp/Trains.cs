using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportApp
{
    public class Trains : Transportation
    {
        private int numOfTrainCars = 0;
         public Trains() : base()
        {
            
            this.numOfDoors.Equals(20);
            this.numOfWheels.Equals(0);
            this.color = "white";
            this.engineType = "Electric";
            this.numOfTrainCars.Equals(10);
        } 
            public override int GetNumWheels(){
            return 8;
            }

            public override string GetEngineType(){
            return "Electric";
            
            }
        
    }
}