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
using System.Drawing.Imaging;

namespace WindowsFormsApp4
{
    public partial class Form3 : Form
    {
        private Stream selectedFile;
        private string filePathStudents = "students.xml";
        private string filePathBooks = "books.xml";
        private XmlDocument xDoc;
        private XmlElement xRoot;
        private XmlElement xStudent;
        private Dictionary<string, string> Params;
        private List<Book> StudentsBooks;
        private string selectedBook;
        public Form3()
        {
            InitializeComponent();
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Save_Student(object sender, EventArgs e)
        {
            int limit=0;
            SaveToDict();
            limit++;
            if (limit > 1)
            {
                return;
            }
            xDoc = new XmlDocument();
            CheckFile();
            xRoot = xDoc.DocumentElement;
            foreach (XmlNode Node in xRoot)
            {
                if (Node.Attributes.GetNamedItem("Surname").Value == textBox2.Text)
                {
                    MessageBox.Show("Такий учень вже існує");
                    Close();
                    return;
                }
            }
            xStudent = xDoc.CreateElement("student");
            AddNode();
            xDoc.Save(filePathStudents);
        }
        private void SaveToDict()
        {
            Params = new Dictionary<string, string>();
            Params.Add("Name", textBox1.Text);
            Params.Add("Surname", textBox2.Text);
            Params.Add("Class", textBox3.Text);
            Params.Add("Image", ImageToString(pictureBox1.Image));
        }
        private void CheckFile()
        {
            try
            {
                using (var sr = new StreamReader(filePathStudents, Encoding.UTF8))
                    xDoc.Load(sr);
            }
            catch
            {
                xDoc = new XmlDocument();
                using (FileStream fstream = new FileStream(filePathStudents, FileMode.OpenOrCreate))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(
                         "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n" +
                         "<students>\n" +
                         "</students>"
                         );
                    fstream.Write(array, 0, array.Length);
                }
                using (var sr = new StreamReader(filePathStudents, Encoding.UTF8))
                    xDoc.Load(sr);
            }
        }
        private void AddNode()
        {
            foreach (KeyValuePair<string, string> keyValue in Params)
            {
                xStudent.SetAttribute(keyValue.Key, keyValue.Value);
            }
            xRoot.AppendChild(xStudent);
        }

        private void Show_FileDialog(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            selectedFile = openFileDialog1.OpenFile();
            PasteTo_PictureBox();
        }

        private void Give_Book(object sender, EventArgs e)
        {
            selectedBook = textBox6.Text.Trim();
            if (!File.Exists(filePathBooks))
            {
                MessageBox.Show("В базі данних немає книг");
                return;
            }
            xDoc = new XmlDocument();
            xDoc.Load(filePathBooks);
            xRoot = xDoc.DocumentElement;
            XmlNodeList xBooks = xRoot.ChildNodes;
        }
        private void PasteTo_PictureBox()
        {
            pictureBox1.Image = Image.FromStream(selectedFile);
        }
        private string ImageToString(Image image)
        {
            using (MemoryStream myStream = new MemoryStream())
            {
                image.Save(myStream, ImageFormat.Gif);
                return Convert.ToBase64String(myStream.ToArray());
            }
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Return_Book(object sender, EventArgs e)
        {

        }

        private void Book_List(object sender, EventArgs e)
        {

        }
    }
    class Book { }
}
