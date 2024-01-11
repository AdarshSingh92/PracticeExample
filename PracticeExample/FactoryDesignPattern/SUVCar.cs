using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public class SUVCar : ICar
    {
        public void DriveCar()
        {
            throw new NotImplementedException();
        }

        public void GetCardDetails()
        {
            Console.WriteLine("This is Nexon SUV car");
        }
    }
}
