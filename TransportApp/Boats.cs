using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportApp
{
    public class Boats : Transportation
    {
         public Boats() : base()
        {
            this.numOfDoors = 2;
            this.numOfWheels = 0;
            this.color = "white";
            this.engineType = "Motor";
        } 
            public override int GetNumWheels(){
            return numOfWheels;
            }

            public override int GetNumDoors()
        {
            return numOfDoors;
        }


    }
}
