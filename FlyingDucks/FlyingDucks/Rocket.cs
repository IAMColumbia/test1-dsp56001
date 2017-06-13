using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyingDucks
{
    public class Rocket : AerialVehicle, IRocketable
    {
        public bool IsIgnited;
    

        public void Launch()
        {
            this.IsIgnited = true;
        }

        public int CurrentAltitude
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

        public bool IsFyling
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

        public void FlyUP()
        {
            throw new NotImplementedException();
        }

        public void FlyDown()
        {
            throw new NotImplementedException();
        }

        public new void Fly()
        {
            throw new NotImplementedException();
        }

        bool IRocketable.IsIgnited
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
    }
}
