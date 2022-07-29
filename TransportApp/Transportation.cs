using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransportApp
{
    public class Transportation
    {
    
    public Transportation (string x, int y)
    {
        this.color = x;
        this.numOfWheels = y;
    } 

     public Transportation(){}

     
        public int numOfWheels {get; set;}
        public int numOfDoors {get; set;}
        public string color {get; set;}
        public string engineType {get; set;}

        public virtual int GetNumDoors(){
            return (numOfDoors);
        }
        public virtual int GetNumWheels(){
            return (numOfWheels);
        }

        public virtual string GetColor(){
            return (color);
        }

        public virtual string GetEngineType(){
            return (engineType);        
        }

    }
}