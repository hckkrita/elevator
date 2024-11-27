﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevatorproject
{
    internal class LiftOpenDoor1 : ILift
    {
        public void LiftCloselift(lift lift)
        {
        }

        public void LiftMoveDown(lift lift)
        {
        }

        public void LiftMoveUp(lift lift)
        {
        }

        public void LiftOpenlift(lift lift)
        {
            if (lift.left1.Left > lift.liftBase.Left - lift.width)
            {
                // Move both lifts away from the center
                lift.left1.Left -= lift.doorSpeed;
                lift.right1.Left += lift.doorSpeed;
            }
            else
            {
                // Stop the opening timer when fully open
                lift.openTimer.Stop();
                lift._CurrentState = new Idle();
                lift.req1.Enabled = false;
                lift.reqG.Enabled = false;
                lift.up.Enabled = false;
                lift.down.Enabled = false;

            }
        }
    }
}
