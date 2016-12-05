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
        Model model;
        public Form1() {
            InitializeComponent();
            model = new Model();
            SongleaderCombo.DataSource = model.GetSongLeaders();
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            int hour = 0, min = 0;
            switch (TempServiceTime.Text)
            {
                case "10:30 AM":
                    hour = 10;
                    min = 30;
                    break;
                case "4:00 PM":
                    hour = 16;
                    break;
                case "6:00 PM":
                    hour = 18;
                    break;
            }
            DateTime date = new DateTime(TempServiceDate.Value.Year, TempServiceDate.Value.Month, TempServiceDate.Value.Day, hour, min, 0);
            Service template = model.getService(date);
            Debug.Print(template.ToString());

            int Newhour = 0, Newmin = 0;
            switch (NewServiceTme.Text)
            {
                case "10:30 AM":
                    Newhour = 10;
                    Newmin = 30;
                    break;
                case "4:00 PM":
                    Newhour = 16;
                    break;
                case "6:00 PM":
                    Newhour = 18;
                    break;
            }

            DateTime NewDate = new DateTime(TempServiceDate.Value.Year, TempServiceDate.Value.Month, TempServiceDate.Value.Day, hour, min, 0);
            Service NewService = model.getService(NewDate);

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
