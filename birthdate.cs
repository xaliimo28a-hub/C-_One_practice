using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birth_date_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            
            string dayOfWeek = txtweek.Text.Trim();
            string month = txtmonth.Text.Trim();
            string dayOfMonth = txtdayofthemonth.Text.Trim();
            string year = txtyear.Text.Trim();

            
            string dateString = $"{dayOfWeek}, {month} {dayOfMonth}, {year}";

            
            dateOutputLabel.Text = dateString;
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
           
        
            
            txtweek.Clear();
            txtmonth.Clear();
            txtdayofthemonth.Clear();
            txtyear.Clear();

           
            dateOutputLabel.Text = string.Empty;

            
            txtweek.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Xiritaanka barnaamijka/foomka
            this.Close();
        }
        

       
        
            
          
        

        private void txtweek_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
    
    

