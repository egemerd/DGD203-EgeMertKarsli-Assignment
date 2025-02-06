using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Game
{
    internal class Car
    {
        private string brand;
        public int price;
        public int fuelAmount;
        public int speed;
        public int fuelSpeed;

        public Car(string aBrand, int aPrice, int aFuelAmount, int aSpeed, int aFuelSpeed)
        {
            Brand = aBrand;
            price = aPrice;
            fuelAmount = aFuelAmount;
            speed = aSpeed;
            fuelSpeed = aFuelSpeed;
        }

        public bool CanArrive()
        {
            if (fuelAmount < 60)
            {
                return false;
            }
            return true;
        }

        public string Brand
        {
            get { return brand; }
            set
            {
                if (value == "BMW" || value == "Tofaş" || value == "Fiat" || value == "Renault")
                {
                    brand = value;

                }
                else
                {
                    brand = "Unkown";
                }


            }




        }

        public override string ToString()
        {
            return $"Brand: {Brand}, Price: {price}, Fuel Amount: {fuelAmount}, Speed: {speed}, Fuel Consumption: {fuelSpeed}";
        }

    }
}
