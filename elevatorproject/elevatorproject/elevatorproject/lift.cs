                                               using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevatorproject
{
    internal class lift

    {
        public int formSize, liftSpeed, doorSpeed,width, groundY, firstY, initial = 0;
        public PictureBox left1, leftG, right1, rightG, liftBase;
        public Timer upTimer, downTimer, closeTimer, openTimer;
        public Button show, req1, reqG, up, down,open,close;
        public ILift _CurrentState;


      public lift(int formSize, int liftSpeed, int doorSpeed, int width,int groundY, int firstY, PictureBox left1, PictureBox leftG, PictureBox right1, PictureBox rightg, PictureBox liftBase, Timer upTimer, Timer downTimer, Timer closeTimer, Timer openTimer, Button show, Button req1, Button reqG, Button up, Button down, Button open, Button close)
        {
            this.formSize = formSize;
            this.liftSpeed = liftSpeed;
            this.doorSpeed = doorSpeed;
            this.width = width;
            this.groundY = groundY;
            this.firstY = firstY;
            this.left1 = left1;
            this.leftG = leftG;
            this.right1 = right1;
            this.rightG = rightg;
            this.liftBase = liftBase;
            this.upTimer = upTimer;
            this.downTimer = downTimer;
            this.closeTimer = closeTimer;
            this.openTimer = openTimer;
            this.show = show;
            this.req1 = req1;
            this.reqG = reqG;
            this.up = up;
            this.down = down;
            this.open = open;
            this.close = close;
            _CurrentState = new Idle();

        }
        public void SetState(ILift state)
        {
            _CurrentState = state;
        }

        public void LiftMoveUp()
        {
            _CurrentState.LiftMoveUp(this);
        }

        public void LiftMoveDown()
        {
            _CurrentState.LiftMoveDown(this);
        }
        public void LiftOpenlift()
        {
            _CurrentState.LiftOpenlift(this);
        }

        public void LiftCloselift()
        {
            _CurrentState.LiftCloselift(this);
        }
    }
}
