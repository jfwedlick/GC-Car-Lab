using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Cars_and_Used_Cars
{
    public class UsedCar : Car
    {
        public double Mileage { get; set; }

        public UsedCar(string make, string model, int year, decimal price, double mileage) : base(make, model, year, price)
        {
            Mileage = mileage;
        }

        public override string ToString()
        {
            string carDetails = $"{Make,-20}{Model,-20}{Year,0}{" (Used)",-20} ${Price,-20}{Mileage,-20}\n";
            return carDetails;
        }
    }


}
