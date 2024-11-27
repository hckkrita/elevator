namespace elevatorproject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.show = new System.Windows.Forms.Button();
            this.closeTimer = new System.Windows.Forms.Timer(this.components);
            this.openTimer = new System.Windows.Forms.Timer(this.components);
            this.upTimer = new System.Windows.Forms.Timer(this.components);
            this.downTimer = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.rightG = new System.Windows.Forms.PictureBox();
            this.right1 = new System.Windows.Forms.PictureBox();
            this.re2 = new System.Windows.Forms.Button();
            this.re1 = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.down = new System.Windows.Forms.Button();
            this.up = new System.Windows.Forms.Button();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.leftG = new System.Windows.Forms.PictureBox();
            this.left1 = new System.Windows.Forms.PictureBox();
            this.liftBase = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftBase)).BeginInit();
            this.SuspendLayout();
            // 
            // show
            // 
            this.show.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.show.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.show.Location = new System.Drawing.Point(482, 157);
            this.show.Margin = new System.Windows.Forms.Padding(2);
            this.show.Name = "show";
            this.show.Size = new System.Drawing.Size(138, 55);
            this.show.TabIndex = 13;
            this.show.UseVisualStyleBackColor = false;
            // 
            // closeTimer
            // 
            this.closeTimer.Tick += new System.EventHandler(this.closeTimer_Tick);
            // 
            // openTimer
            // 
            this.openTimer.Tick += new System.EventHandler(this.openTimer_Tick);
            // 
            // upTimer
            // 
            this.upTimer.Tick += new System.EventHandler(this.upTimer_Tick);
            // 
            // downTimer
            // 
            this.downTimer.Tick += new System.EventHandler(this.downTimer_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(691, 87);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(380, 474);
            this.dataGridView1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.button1.Location = new System.Drawing.Point(979, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rightG
            // 
            this.rightG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rightG.BackgroundImage")));
            this.rightG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rightG.Location = new System.Drawing.Point(267, 331);
            this.rightG.Name = "rightG";
            this.rightG.Size = new System.Drawing.Size(83, 265);
            this.rightG.TabIndex = 5;
            this.rightG.TabStop = false;
            // 
            // right1
            // 
            this.right1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("right1.BackgroundImage")));
            this.right1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.right1.Location = new System.Drawing.Point(267, 24);
            this.right1.Name = "right1";
            this.right1.Size = new System.Drawing.Size(83, 265);
            this.right1.TabIndex = 3;
            this.right1.TabStop = false;
            // 
            // re2
            // 
            this.re2.BackgroundImage = global::elevatorproject.Properties.Resources.down;
            this.re2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.re2.Location = new System.Drawing.Point(358, 431);
            this.re2.Name = "re2";
            this.re2.Size = new System.Drawing.Size(36, 33);
            this.re2.TabIndex = 12;
            this.re2.UseVisualStyleBackColor = true;
            this.re2.Click += new System.EventHandler(this.re2_Click);
            // 
            // re1
            // 
            this.re1.BackgroundImage = global::elevatorproject.Properties.Resources.liftup1;
            this.re1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.re1.Location = new System.Drawing.Point(356, 98);
            this.re1.Name = "re1";
            this.re1.Size = new System.Drawing.Size(38, 39);
            this.re1.TabIndex = 11;
            this.re1.UseVisualStyleBackColor = true;
            this.re1.Click += new System.EventHandler(this.re1_Click);
            // 
            // close
            // 
            this.close.BackgroundImage = global::elevatorproject.Properties.Resources.close;
            this.close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.close.Location = new System.Drawing.Point(560, 294);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(60, 56);
            this.close.TabIndex = 10;
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // open
            // 
            this.open.BackgroundImage = global::elevatorproject.Properties.Resources.open;
            this.open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.open.Location = new System.Drawing.Point(478, 294);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(60, 56);
            this.open.TabIndex = 9;
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // down
            // 
            this.down.BackgroundImage = global::elevatorproject.Properties.Resources.groundb;
            this.down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.down.Location = new System.Drawing.Point(560, 232);
            this.down.Name = "down";
            this.down.Size = new System.Drawing.Size(60, 56);
            this.down.TabIndex = 8;
            this.down.UseVisualStyleBackColor = true;
            this.down.Click += new System.EventHandler(this.down_Click);
            // 
            // up
            // 
            this.up.BackgroundImage = global::elevatorproject.Properties.Resources._1b;
            this.up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.up.Location = new System.Drawing.Point(478, 232);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(60, 56);
            this.up.TabIndex = 7;
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox7.BackgroundImage")));
            this.pictureBox7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox7.Location = new System.Drawing.Point(464, 138);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(174, 246);
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // leftG
            // 
            this.leftG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("leftG.BackgroundImage")));
            this.leftG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.leftG.Location = new System.Drawing.Point(184, 331);
            this.leftG.Name = "leftG";
            this.leftG.Size = new System.Drawing.Size(83, 265);
            this.leftG.TabIndex = 4;
            this.leftG.TabStop = false;
            // 
            // left1
            // 
            this.left1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("left1.BackgroundImage")));
            this.left1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.left1.Location = new System.Drawing.Point(184, 24);
            this.left1.Name = "left1";
            this.left1.Size = new System.Drawing.Size(83, 265);
            this.left1.TabIndex = 2;
            this.left1.TabStop = false;
            // 
            // liftBase
            // 
            this.liftBase.BackgroundImage = global::elevatorproject.Properties.Resources.elevator;
            this.liftBase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.liftBase.Location = new System.Drawing.Point(191, 331);
            this.liftBase.Name = "liftBase";
            this.liftBase.Size = new System.Drawing.Size(151, 265);
            this.liftBase.TabIndex = 1;
            this.liftBase.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rightG);
            this.Controls.Add(this.right1);
            this.Controls.Add(this.show);
            this.Controls.Add(this.re2);
            this.Controls.Add(this.re1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.open);
            this.Controls.Add(this.down);
            this.Controls.Add(this.up);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.leftG);
            this.Controls.Add(this.left1);
            this.Controls.Add(this.liftBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rightG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liftBase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox liftBase;
        private System.Windows.Forms.PictureBox left1;
        private System.Windows.Forms.PictureBox right1;
        private System.Windows.Forms.PictureBox rightG;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button down;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button re1;
        private System.Windows.Forms.Button re2;
        private System.Windows.Forms.PictureBox leftG;
        private System.Windows.Forms.Button show;
        private System.Windows.Forms.Timer closeTimer;
        private System.Windows.Forms.Timer openTimer;
        private System.Windows.Forms.Timer upTimer;
        private System.Windows.Forms.Timer downTimer;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
    }
}

