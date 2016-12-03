using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WSO
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            string tmpdate = TempServiceTime.Text;
            Debug.Print("Template Service Time = " + tmpdate);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resetFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewServiceTme.Text = "";
            TempServiceTime.Text = "";
            TitleTxt.Text = "";
            ServiceThemeTxt.Text = "";
        }

        private void SongleaderCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
