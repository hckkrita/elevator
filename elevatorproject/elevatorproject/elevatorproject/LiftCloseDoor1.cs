using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorproject
{
    internal class LiftCloselift1 : ILift
    {
        public void LiftCloselift(lift lift)
        {
            if (lift.left1.Left < lift.liftBase.Left)
            {
                // Move both lifts toward the center
                lift.left1.Left += lift.liftSpeed;
                lift.right1.Left -= lift.liftSpeed;
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
