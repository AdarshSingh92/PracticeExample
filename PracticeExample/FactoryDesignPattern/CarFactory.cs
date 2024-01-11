using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class CarFactory
    {
        public ICar CreateCarInstance(string carType)
        {
            switch (carType)
            {
                case "sedon":
                    return new SedonCar();
                case "SUV":
                    return new SUVCar();
            }
            return new Car();
        }
    }
}
