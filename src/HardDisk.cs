using System;
using System.Collections.Generic;
using System.Text;

namespace Equipment
{
    public class HardDisk 
    {
        int yearOfCreation;
        int newPrice;
        int capacityGB;

        public HardDisk( int yearOfCreation, int newPrice, int capacityGB)
        {
            this.yearOfCreation = yearOfCreation;
            this.newPrice = newPrice;
            this.capacityGB = capacityGB;
        }

        public double GetPrice()
        {
            return yearOfCreation < ( DateTime.Today.Year - 4 ) ? 0 : newPrice - ( DateTime.Today.Year - yearOfCreation ) * 5000;
        }

        public int GetAge()
        {
            return DateTime.Today.Year - yearOfCreation;
        }

    }
}
