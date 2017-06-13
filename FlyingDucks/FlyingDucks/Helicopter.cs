using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingDucks
{
    class Helicopter : IFlyable
    {

        protected int currentAltitude;  //Private instance data member
        public bool IsFyling { get; set; }

        public Helicopter()
        {
            this.CurrentAltitude = 0;
        }

        public int CurrentAltitude  //Accessor 
        {
            get
            {
                return currentAltitude;
            }
            set
            {
                currentAltitude = value;
            }
        }

        public void FlyUP()
        {
            this.CurrentAltitude++;
        }

        public void FlyDown()
        {
            this.CurrentAltitude--;
        }


        public void Fly()
        {
            this.IsFyling = true;
        } 
    }
}
