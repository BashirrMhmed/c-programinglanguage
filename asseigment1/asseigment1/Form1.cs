using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace asseigment1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            string name = txtname.Text;
            int id = int.Parse(txtstudentid.Text);
            string department = txtdepartment.Text;
            int semester = int.Parse(txtsemester.Text);
            string output;

            output = name + ", " + id + ", " + department + ", " + semester;
            lbloutput.Text = output;
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtstudentid.Clear();
            txtdepartment.Clear();
            txtsemester.Clear();
            lbloutput.Text = "";
            
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
