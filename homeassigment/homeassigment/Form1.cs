using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homeassigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnshowdate_Click(object sender, EventArgs e)
        {
            //creating variable
            string day_of_t_heweek, name_of_the_month, numeric_day, year, full_date;
            day_of_t_heweek = dayoftheweek.Text;
            name_of_the_month= txtmonth.Text;
            numeric_day = txtnumericofthemonth.Text;
            year = txtoftheyear.Text;

            full_date = day_of_t_heweek + "," + name_of_the_month + "," + "," + numeric_day + "," + year;

            lblouput.Text = full_date;



        }

        private void btnclar_Click(object sender, EventArgs e)
        {
            dayoftheweek.Text = "";
            txtmonth.Clear();
            txtnumericofthemonth.Text=string.Empty;
            txtoftheyear.Clear();


            lblouput.Text = "";
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
