using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorproject
{
    internal interface ILift
    {
        void LiftMoveUp(lift lift);
        void LiftMoveDown(lift lift);

        void LiftOpenlift(lift lift);
        void LiftCloselift(lift lift);



    }
}
