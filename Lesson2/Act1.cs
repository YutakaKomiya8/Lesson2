using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lesson2
{
    public partial class Act_1 : Form
    {
        public Act_1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //code for background color
            this.BackColor = Color.DarkGray;
            //codes for labels
            label1.Text = "Student Name:";
            label2.Text = "Programs";
            label3.Text = "Student Number:";
            label4.Text = "Year Level:";
            label5.Text = "Date Enrolled:";
            label6.Text = "Scholar:";
            label7.Text = "Course Number:";
            label8.Text = "Course Code:";
            label9.Text = "Course Desc:";
            label10.Text = "Unit Lecture:";
            label11.Text = "Unit Laboratory:";
            label12.Text = "Time:";
            label13.Text = "Day:";
            label14.Text = "Credit Units:";
            label15.Text = "Total Number of Units:";
            label16.Text = "Laboratory Fee:";
            label17.Text = "Total Tuition Fee:";
            label18.Text = "Total Miscellanous Fee:";
            label19.Text = "Cisco Lab. Fee:";
            label20.Text = "Exam Booklet Fee:";
            label21.Text = "Total Tuition and Fee:";
            label22.Text = "#";
            label23.Text = "Course Code:";
            label24.Text = "Course Desc:";
            label25.Text = "Unit Lec:";
            label26.Text = "Unit Lab:";
            label27.Text = "Credit Units:";
            label28.Text = "Time:";
            label29.Text = "Day:";
            label30.Text = "Total Tuition Fee:";
            label31.Text = "Total Miscellanous Fee:";
            label32.Text = "Other School Fees:";
            label33.Text = "Computer Laboratory Fee:";
            label34.Text = "CISCO Lab Fee:";
            label35.Text = "Exam Booklet:";
            label36.Text = "Total Other School Fees:";
            label37.Text = "Total Number of Units:";
            label38.Text = "Total Tuition and Fees:";

            //color of button
            submitbtn.BackColor = Color.Black;

            //comboBox1
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Items.AddRange(new object[] {"Civil Engineering",
            "Mechanical Engineering",
            "Electrical Engineering",
            "Electronics Engineering",
            "Computer Engineering",
            "Industrial Engineering",
            "Aeronautical Engineering"});



        }

        private void submitbtn_Click(object sender, EventArgs e)
        {
            //Textbox
            textBox28.Text = textBox14.Text;
            textBox29.Text = textBox13.Text;
            textBox32.Text = textBox15.Text;
            textBox36.Text = textBox12.Text;
            textBox35.Text = textBox11.Text;
            textBox34.Text = "";
            textBox31.Text = textBox16.Text;
            textBox30.Text = textBox10.Text;
            textBox14.Clear();
            textBox13.Clear();
            textBox15.Clear();
            textBox12.Clear();
            textBox11.Clear();
            textBox16.Clear();
            textBox10.Clear();

            //List Boxes
            listBox1.Items.Insert(0, textBox2.Text);
            listBox2.Items.Insert(0, textBox3.Text);
            listBox3.Items.Insert(0, textBox4.Text);
            listBox4.Items.Insert(0, textBox5.Text);
            listBox5.Items.Insert(0, textBox9.Text);
            listBox6.Items.Insert(0, textBox17.Text);
            listBox7.Items.Insert(0, textBox8.Text);
            listBox8.Items.Insert(0, textBox7.Text);
            
        }

        private void browsebtn_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;

                    image1.ImageLocation = imageLocation;
                }
            }catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Newbtn_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
            textBox10.Clear();
            textBox11.Clear();
            textBox12.Clear();
            textBox13.Clear();
            textBox14.Clear();
            textBox15.Clear();
            textBox16.Clear();
            textBox17.Clear();
            textBox18.Clear();
            textBox19.Clear();
            textBox28.Clear();
            textBox29.Clear();
            textBox30.Clear();
            textBox31.Clear();
            textBox32.Clear();
            textBox34.Clear();
            textBox35.Clear();
            textBox36.Clear();
            comboBox1.Text = ("");
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
