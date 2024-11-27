using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elevatorproject
{
    public partial class Form1 : Form
    {
        public int liftSpeed = 10, doorSpeed = 7, width, groundY, firstY;

    
       
        private lift lift;
        DataTable datatable = new DataTable();
        Database db=new Database();
        public Form1()
        {
            InitializeComponent();
            groundY = leftG.Location.Y;
            firstY = left1.Location.Y;
            width = liftBase.Width / 2;
            datatable.Columns.Add("LogTime");
            datatable.Columns.Add("EventDescription");
            lift = new lift(this.ClientSize.Height,liftSpeed,doorSpeed,width,groundY,firstY,left1,leftG,right1,rightG,liftBase,upTimer,downTimer,closeTimer,openTimer,show,re1,re2,up,down,open,close);
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Time";
            dataGridView1.Columns[1].Name = "Events";

        }
        private void showMsg(string message)
        {
            string currentTime = DateTime.Now.ToString("hh:mm:ss");

            datatable.Rows.Add(currentTime, message);
            dataGridView1.Rows.Add(currentTime, message);

            db.InsertLogsIntoDB(datatable);
        }
        private void up_Click(object sender, EventArgs e)
        {
            lift.SetState(new LiftMovingUp());
            upTimer.Start();
            re1.Enabled = false;
            re2.Enabled = false;
            down.Enabled = false;
            up.Enabled = false;
            close.Enabled = false;
            open.Enabled = false;
            showMsg("Lift is going to reach first floor!");
        }

        private void down_Click(object sender, EventArgs e)
        {
            lift.SetState(new LiftMovingDown());
            downTimer.Start();
            re1.Enabled = false;
            re2.Enabled = false;
            down.Enabled = false;
            up.Enabled = false;
            close.Enabled = false;
            open.Enabled = false; ;
            showMsg("Lift is arriving at ground floor!");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void open_Click(object sender, EventArgs e)
        {
            if (lift.initial == 1)
            {
                lift.SetState(new LiftOpenDoor1());
                openTimer.Start();
                re1.Enabled = false;
                re2.Enabled = false;
                down.Enabled = false;
                up.Enabled = false;
                open.Enabled = false;
                showMsg("Door of first floor is being opened!");

            }
            else
            {
                lift.SetState(new LiftOpenDoorG());
                openTimer.Start();
                re1.Enabled = false;
                re2.Enabled = false;
                down.Enabled = false;
                up.Enabled = false;
                open.Enabled = false;
                showMsg("Door of ground floor is being opened!");

            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            if (lift.initial == 1)
            {
                lift.SetState(new LiftCloselift1());
                closeTimer.Start();
                re1.Enabled = false;
                re2.Enabled = false;
                down.Enabled = false;
                up.Enabled = false;
                open.Enabled = false;
                showMsg("Door of first floor is being closed!");

            }
            else
            {
                lift.SetState(new LiftCloseliftG());
                closeTimer.Start();
                re1.Enabled = false;
                re2.Enabled = false;
                down.Enabled = false;
                up.Enabled = false;
                open.Enabled = false;
                showMsg("Door of ground floor is being closed!");

            }
        }

        private void closeTimer_Tick(object sender, EventArgs e)
        {
            lift.LiftCloselift();

        }

        private void openTimer_Tick(object sender, EventArgs e)
        {
            lift.LiftOpenlift();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db.loadLogsFromDB(datatable, dataGridView1);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Delete button clicked.");
            db.truncateLogsTable(dataGridView1);
        }

        private void upTimer_Tick(object sender, EventArgs e)
        {
            lift.LiftMoveUp();

        }

        private void downTimer_Tick(object sender, EventArgs e)
        {
            lift.LiftMoveDown();
        }

        private void re2_Click(object sender, EventArgs e)
        {
            lift.SetState(new LiftMovingDown());
            downTimer.Start();
            re1.Enabled = false;
            re2.Enabled = false;
            down.Enabled = false;
            up.Enabled = false;
            close.Enabled = false;
            open.Enabled = false; ;
            //showMsg("Lift is arriving at ground floor!");
        }

        private void re1_Click(object sender, EventArgs e)
        {
            lift.SetState(new LiftMovingUp());
            upTimer.Start();
            re1.Enabled = false;
            re2.Enabled = false;
            down.Enabled = false;
            up.Enabled = false;
            close.Enabled = false;
            open.Enabled = false;
            //showMsg("Lift is going to reach first floor!");

        }

    }
}
