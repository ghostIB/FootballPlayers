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
using System.Xml;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        Form3 Student;
        string filePath = "students.xml";
        XmlDocument xDoc;
        XmlElement xRoot;
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_Book(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
        }

        private void Add_Student(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
        }

        private void Search_Student(object sender, EventArgs e)
        {
            Student = new Form3();
            string[] inputName = textBox1.Text.Split(' ');
            if (!File.Exists(filePath))
            {
                MessageBox.Show("В базі данних немає учнів");
                return;
            }
            xDoc = new XmlDocument();
            xDoc.Load(filePath);
            xRoot = xDoc.DocumentElement;
            XmlNodeList xBooks = xRoot.ChildNodes;
            foreach (XmlElement xBook in xBooks)
            {
                if (Array.Exists(inputName,element=>element==xBook.GetAttribute("Surname")))
                {
                    Student.textBox1.Text = xBook.Attributes["Name"].Value;
                    Student.textBox2.Text = xBook.Attributes["Surname"].Value;
                    Student.textBox3.Text = xBook.Attributes["Class"].Value;
                    Student.pictureBox1.Image=SetPicture(xBook.Attributes["Image"].Value);
                    break;
                }
            }
            Student.label6.Visible = true;
            Student.textBox6.Visible = true;
            Student.button2.Visible = true;
            Student.button4.Visible = true;
            Student.button5.Visible = true;
            Student.Show();
        }
        private Image SetPicture(string stringImage)
        {
            byte[] imageBytes = Convert.FromBase64String(stringImage);
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {
                ms.Write(imageBytes, 0, imageBytes.Length);
                Image image = Image.FromStream(ms, true);
                return image;
            }
        }
    }
}
