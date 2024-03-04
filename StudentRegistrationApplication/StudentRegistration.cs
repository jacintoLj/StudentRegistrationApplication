using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class StudentRegistration : Form
    {
        public StudentRegistration()
        {
            InitializeComponent();

            string[] array = { "January", "Febuary", "March", "April", "May",
            "June", "July", "August", "September", "October", "November", "December" };
            
            for (int i = 1; i <= 31; i++)
            {
                comboBox1.Items.Add(i);
            }

            foreach (string month in array)          
            {
                comboBox2.Items.Add(month);
            }

            for (int i = 1900; i <= 2024; i++)
            {
                comboBox3.Items.Add(i);
            }

            ArrayList program = new ArrayList();
            program.Add("Bachelor of Science in Computer Science");
            program.Add("Bachelor of Science in Information Technology");
            program.Add("Bachelor of Science in Information System");
            program.Add("Bachelor of Science in Computer Engineering");

            foreach(string programList in program)
            {
                comboBox4.Items.Add(programList);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string lastName, firstName, middleName;
            string gender = " ";
            lastName = textBox2.Text;
            firstName = textBox1.Text;
            middleName = textBox3.Text;

            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else
            {
                gender = radioButton2.Text;
            }
            MessageBox.Show("Student name: " + firstName + " " + middleName + " " +
                lastName + "\n" + "Gender: " + gender + "\n" + "Date of birth: " + comboBox1.Text + "/" +
                comboBox2.Text + "/" + comboBox3.Text + "\n" + "Program: " + comboBox4.Text);

        }
    }
}
