using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace zadachi_za_podgotowka
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public class Student
        {
            public string ime;
            public string egn;
            public string birthPlace;
            public double dergee;

        }
        Student student = new Student();

      
    //    StreamReader r = new StreamReader("TextFile.txt");
       
        public Student ReadFile(string s)
        {
            Student st = new Student();
            string[] arr = s.Split('/');
            st.ime = arr[0];
            st.egn = arr[1];
            st.birthPlace = arr[2];
            st.dergee = double.Parse(arr[3]);
            return st;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            richTextBox1.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamReader r = new StreamReader("student.txt");
            richTextBox1.Text = r.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            student.ime = textBox1.Text;
            student.egn = textBox2.Text;
            student.birthPlace = textBox3.Text;
            student.dergee = double.Parse(textBox4.Text);
            string newStr = $"{student.ime}/{student.egn}/{student.birthPlace}/{student.dergee}/\n";
          //  richTextBox1.Text = newStr;
            StreamWriter file = new StreamWriter("student.txt", true, Encoding.GetEncoding("Unicode"));
            file.WriteLine(newStr);
            file.Close();
        }
    }
}
