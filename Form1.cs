using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<double> gpaList = new List<double>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBox1.Text, out double gpa) && gpa >= 0.0 && gpa <= 4.0)
            {
                gpaList.Add(gpa);
                UpdateGPAInfo();
                textBox1.Clear();
            }
        }
        private void UpdateGPAInfo()
        {
            if (gpaList.Count > 0)
            {
                double avgGPA = gpaList.Average(); 
                double maxGPA = gpaList.Max();     
                double minGPA = gpaList.Min();     
                int totalStudents = gpaList.Count; 

                
                textBox2.Text = avgGPA.ToString("F2");     
                textBox3.Text = totalStudents.ToString();  
                textBox4.Text = maxGPA.ToString("F2");     
                textBox5.Text = minGPA.ToString("F2");     
            }
            else
            {            
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
            }
        }

    }
}
