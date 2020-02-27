using CrystalDecisions.CrystalReports.Engine;
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
    public partial class QuizReportViewer : Form
    {
        private ReportClass report;
        public QuizReportViewer(ReportClass report)
        {
            InitializeComponent();
            this.report = report;
        }

        private void QuizReportViewer_Load(object sender, EventArgs e)
        {
            viewer.ReportSource = report;
        }

        public CrystalDecisions.Windows.Forms.CrystalReportViewer Viewer
        {
            get { return viewer; }
            set { viewer = value; }
        }
    }
}
