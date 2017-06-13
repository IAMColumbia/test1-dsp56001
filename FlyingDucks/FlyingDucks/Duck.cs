using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyingDucks
{
    public class Duck : Bird
    {
        public string DuckSound;
       

        public string Quack()
        {
            return this.DuckSound;
        }
    }
}
