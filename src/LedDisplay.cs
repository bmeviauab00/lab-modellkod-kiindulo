using System;
using System.Collections.Generic;
using System.Text;

namespace Equipment
{
    public class LedDisplay : DisplayBase
    {
        public LedDisplay(int _creationYear, int _originalPrice, int _size, int _responseTime)
        {
            this.manufacturingYear = _creationYear;
            this.price = _originalPrice;
            this.size = _size;
            this.responseTime = _responseTime;
        }

        int responseTime;
    }
}
