using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorproject
{
    internal class LiftCloseliftG : ILift
    {
        public void LiftCloselift(lift lift)
        {
            if (lift.leftG.Left < lift.liftBase.Left)
            {
                // Move both lifts toward the center
                lift.leftG.Left += lift.liftSpeed;
                lift.rightG.Left -= lift.liftSpeed;
            }
            else
            {
                // Stop the closing timer when fully closed
                lift.closeTimer.Stop();
                lift._CurrentState = new Idle();

                lift.req1.Enabled = true;
                lift.reqG.Enabled = true;
                lift.up.Enabled = true;
                lift.down.Enabled = true;



            }
        }

        public void LiftMoveDown(lift lift)
        {
        }

        public void LiftMoveUp(lift lift)
        {
        }

        public void LiftOpenlift(lift lift)
        {
        }
    }
}
