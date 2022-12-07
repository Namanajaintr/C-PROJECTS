using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public interface ICar {

        public void IStart();
        public void IDrive();
        public void IStop();
    }
    public class BMW : ICar
    {
        // Car owner= new Car(); cannot create an obj of interface 
        //public void startBMW() {
        //    owner.Start();
        //}
        public  void  IStart() {
            Console.WriteLine("started the BMW car");

        }
        public void IDrive() {
            Console.WriteLine("driving the BMW car");
        }
        public void IStop() {

            Console.WriteLine("stopped the BMW car");
        }

    }
    public class RR : ICar
    {
        //Car owner= new Car();
        public void IStart() {
            Console.WriteLine("started the RR car");

        }
        public void IDrive() {
            Console.WriteLine("driving the RR car");
        }
        public void IStop() {

            Console.WriteLine("stopped the RR car");
        }
    }

    public class Ambassdor : ICar
    {
        //Car owner= new Car();
        public void IStart() {
            Console.WriteLine("started the Ambassdor car");

        }
        public void IDrive() {
            Console.WriteLine("driving the Ambassdor car");
        }
        public void IStop() {

            Console.WriteLine("stopped the Ambassdor car");
        }

    }

//    Factory Design Pattern In C#

//This pattern comes under the creational patterns which are widely used in programming constructs.In other words,
//* “This Pattern provides the best way to create the Objects.
//*In Factory patterns we create the object of the Class without Exposing the Creation/Instantiation
//* Logic to the User who wants to create the Object and 
//*then return the newly Created object using the Common Interface which is inherited by the Class”.

    public class CarFactory
    {
        //Parametrized Factory 
        public static ICar getCar(string Type) {
            ICar ObjectType = null;
            if (Type.ToLower().Equals("bmw")) {
                ObjectType = new BMW();
                ObjectType.IDrive();
                ObjectType.IStart();
                ObjectType.IStop();
            }
            else if (Type.ToLower().Equals("rr")) {
                ObjectType = new RR();
                ObjectType.IDrive();
                ObjectType.IStart();
                ObjectType.IStop();
            }
            else if (Type.ToLower().Equals("ambassdor")) {
                ObjectType = new Ambassdor();
                ObjectType.IDrive();
                ObjectType.IStart();
                ObjectType.IStop();
            }
            return ObjectType;

        }
    } 

}

