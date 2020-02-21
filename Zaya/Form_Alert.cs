using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaya
{
    public partial class Form_Alert : Form
    {
        private string Message { get; set; }

        public Form_Alert()
        {
            InitializeComponent();
        }
        public enum enumAction
        {
            wait,
            start,
            close
        }

        public enum TypeMessage
        {
            SUCCESS,
            WARNING,
            ERROR,
            INFO
        }

        private Form_Alert.enumAction action;

        private int x, y;
        public void ShowAlert (String msj, TypeMessage type)
        {
            this.Message = msj;
            this.Opacity = 0.0;
            this.StartPosition = FormStartPosition.Manual;
            string Frame;

            for(int i=0;i<10;i++)
            {
                Frame = "alert" + i.ToString();
                Form_Alert frm = (Form_Alert)Application.OpenForms[Frame];

                if(frm==null)
                {

                    this.Name = Frame;
                    this.x = Screen.PrimaryScreen.WorkingArea.Width - this.Width + 15;
                    this.x = Screen.PrimaryScreen.WorkingArea.Height - this.Height * i;
                    y = 0;
                    this.Location = new Point(this.x, this.y);
                    break;

                }

            }

            this.x = Screen.PrimaryScreen.WorkingArea.Width - base.Width - 5;
            this.lbl_msj.Text = Message;
            switch(type)
            {
                case TypeMessage.ERROR:
                    this.BackColor = Color.DarkRed;
                    break;
                case TypeMessage.WARNING:
                    this.BackColor = Color.DarkOrange;
                    break;
                case TypeMessage.INFO:
                    this.BackColor = Color.RoyalBlue;
                    break;
                case TypeMessage.SUCCESS:
                    this.BackColor = Color.SeaGreen;
                    break;
            }
            this.Show();
            this.action = enumAction.start;
            this.timer1.Interval = 1;
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            action = enumAction.close;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            switch(this.action)
            {

                case enumAction.wait:
                    timer1.Interval = 3000;
                    action = enumAction.close;
                    break;

                case enumAction.start:
                    timer1.Interval = 1;
                    this.Opacity += 0.1;
                    if (this.x < this.Location.X) 
                    {
                        this.Left--;
                    }
                    else{
                        if (this.Opacity ==1.0)
                        {
                            action = enumAction.wait;
                        }

                    }
                    break;
                case enumAction.close:
                    timer1.Interval = 1;
                    this.Opacity -= 0.1;


                    this.Left -= 3;
                  
                        if (this.Opacity == 0.0)
                        {
                        base.Close();
                        }
                        break;
              
            }
        }

        private void Form_Alert_Load(object sender, EventArgs e)
        {

        }
    }
}
