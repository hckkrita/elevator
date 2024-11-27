using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorproject
{
    internal class LiftMovingUp : ILift
    {
        public void LiftCloselift(lift lift)
        {
        }

        public void LiftMoveDown(lift lift)
        {
        }

        public void LiftOpenlift(lift lift)
        {
        }

       public void LiftMoveUp(lift lift)
        {
            int distanceToFirstFloor = lift.liftBase.Top - lift.firstY;
            if (distanceToFirstFloor >= lift.liftSpeed)
            {
                lift.liftBase.Top -= lift.liftSpeed;
                lift.open.Enabled = false;
                lift.close.Enabled = false;
            }
            else
            {
                lift.liftBase.Top = lift.firstY;
                lift.SetState(new Idle());
                lift.initial = 1;
                lift.upTimer.Stop();
                lift.show.Text = $"1";
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
