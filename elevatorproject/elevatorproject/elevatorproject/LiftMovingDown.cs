using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorproject
{
    internal class LiftMovingDown : ILift

    {
        public void LiftCloselift(lift lift)
        {
        }

        public void LiftMoveUp(lift lift)
        {
        }

        public void LiftOpenlift(lift lift)
        {
        }

        public void LiftMoveDown(lift lift)
        {
            int distanceToGround = lift.groundY - lift.liftBase.Top;

            if (distanceToGround > lift.liftSpeed)
            {
                lift.liftBase.Top += lift.liftSpeed;
                lift.open.Enabled = false;
                lift.close.Enabled = false;
            }
            else
            {
                lift.liftBase.Top = lift.groundY;
                lift.SetState(new Idle());
                lift.downTimer.Stop();

                lift.initial = 0;
                lift.show.Text = $"G";
                lift.req1.Enabled = true;
                lift.reqG.Enabled = true;
                lift.up.Enabled = true;
                lift.down.Enabled = true;
                lift.close.Enabled = true;
                lift.open.Enabled = true;
                lift.open.PerformClick();

            }
        }
    }
}
