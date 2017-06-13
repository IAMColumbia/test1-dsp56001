using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingDucks
{
    interface IFlyable
    {
        int CurrentAltitude { get; set; }
        bool IsFyling { get; set; }

        void FlyUP();
        void FlyDown();
        void Fly();
    }
}
