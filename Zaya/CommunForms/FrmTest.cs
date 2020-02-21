using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zaya.CommunForms
{
    public partial class FrmTest : Form
    {
        private Color HOVER_COLOR = Color.FromArgb(30, 182, 201);
        private Color TRANSPARENT_COLOR = Color.Transparent;
        public FrmTest()
        {
            InitializeComponent();
        }

        private void FrmTest_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLesson_Click(object sender, MouseEventArgs e)
        {
            panelLeft.Height = btnLesson.Height;
            panelLeft.Top = btnLesson.Top;

            var frm = new Form_Alert();
            frm.ShowAlert("bonjour", Form_Alert.TypeMessage.SUCCESS);
        }

        private void btnQuiz_MouseClick(object sender, MouseEventArgs e)
        {
            panelLeft.Height = btnQuiz.Height;
            panelLeft.Top = btnQuiz.Top;
        }

        private void btnModels_MouseClick(object sender, MouseEventArgs e)
        {
            panelLeft.Height = btnModels.Height;
            panelLeft.Top = btnModels.Top;
        }

        private void btnUnites_MouseClick(object sender, MouseEventArgs e)
        {
            panelLeft.Height = btnUnites.Height;
            panelLeft.Top = btnUnites.Top;
           
        }

        private void btnQuizPlayed_MouseClick(object sender, MouseEventArgs e)
        {
            panelLeft.Height = btnQuizPlayed.Height;
            panelLeft.Top = btnQuizPlayed.Top;
        }

        private void btnLesson_MouseHover(object sender, EventArgs e)
        {
            btnLesson.BackColor = HOVER_COLOR;
        }

        private void btnQuiz_MouseHover(object sender, EventArgs e)
        {
            btnQuiz.BackColor = HOVER_COLOR;
        }

        private void btnModels_MouseHover(object sender, EventArgs e)
        {
            btnModels.BackColor = HOVER_COLOR;
        }

        private void btnUnites_MouseHover(object sender, EventArgs e)
        {
            btnUnites.BackColor = HOVER_COLOR;
        }

        private void btnQuizPlayed_MouseHover(object sender, EventArgs e)
        {
            btnQuizPlayed.BackColor = HOVER_COLOR;
        }

        private void btnLesson_MouseLeave(object sender, EventArgs e)
        {
            btnLesson.BackColor = TRANSPARENT_COLOR;
        }

        private void btnQuiz_MouseLeave(object sender, EventArgs e)
        {
            btnQuiz.BackColor = TRANSPARENT_COLOR;
        }

        private void btnModels_MouseLeave(object sender, EventArgs e)
        {
            btnModels.BackColor = TRANSPARENT_COLOR;
        }

        private void btnUnites_MouseLeave(object sender, EventArgs e)
        {
            btnUnites.BackColor = TRANSPARENT_COLOR;
        }

        private void btnQuizPlayed_MouseLeave(object sender, EventArgs e)
        {
            btnQuizPlayed.BackColor = TRANSPARENT_COLOR;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
