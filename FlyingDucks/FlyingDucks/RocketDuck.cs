using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyingDucks
{
    public class RocketDuck : Duck, IRocketable
    {
        public bool IsIgnited
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public void Launch()
        {
            throw new NotImplementedException();
        }
    }
}
