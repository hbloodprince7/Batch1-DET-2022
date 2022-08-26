using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    public class Circle
    {
        int r;
        public Circle(int radius)
        {
            this.r = radius;
        }

        public double Area()
        {
            return Math.PI * r;
        }
          
    }

}

