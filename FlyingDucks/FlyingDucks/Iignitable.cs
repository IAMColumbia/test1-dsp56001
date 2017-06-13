using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlyingDucks
{
    public interface IRocketable :  IFlyable
    {
        bool IsIgnited { get; set; }
        void Launch();
    }
}
