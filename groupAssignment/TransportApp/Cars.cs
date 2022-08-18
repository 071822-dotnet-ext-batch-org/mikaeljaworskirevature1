using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportApp
{
    public class Cars : Transportation
    {
        public Cars()
        {
            this.numOfDoors = 4;
            this.numOfWheels.Equals(4);
            this.color = "Black";
            this.engineType = "Motor";
        } 

        public override int GetNumDoors()
        {
            return numOfDoors;
        }



    }
}