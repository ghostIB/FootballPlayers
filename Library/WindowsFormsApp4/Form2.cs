using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.IO;

namespace WindowsFormsApp4
{
    public partial class Form2 : Form
    {
        private XmlDocument xDoc;
        private XmlElement xRoot;
        private XmlElement xBook;
        private XmlElement tmpNode;
        private Dictionary<string, string> Params;
        private string FilePath = "books.xml";
        private int limit = 0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Save_File(object sender, EventArgs e)
        {
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
                    if (Node.Attributes.GetNamedItem("name").Value == textBox1.Text)
                    {
                        MessageBox.Show("Така книга вже існує");
                        Close();
                        return;
                    }
                }
                xBook=xDoc.CreateElement("book");
                xBook.SetAttribute("name", textBox1.Text);
                AddNode();
                xDoc.Save(FilePath);
        }
        private void SaveToDict()
        {
            Params = new Dictionary<string, string>();
            Params.Add("Title", textBox1.Text);
            Params.Add("Author", textBox2.Text);
            Params.Add("Straight", comboBox1.Text);
            Params.Add("Genre", comboBox2.Text);
            int number = 0;
            try
            {
                number = int.Parse(textBox3.Text);
            }
            catch
            {
            }
            Params.Add("Quantity", number.ToString());
        }
        private void CheckFile()
        {
            try
            {
                using (var sr = new StreamReader(FilePath, Encoding.UTF8))
                    xDoc.Load(sr);
            }
            catch
            {
                xDoc = new XmlDocument();
                using (FileStream fstream = new FileStream(FilePath, FileMode.OpenOrCreate))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(
                         "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\n" +
                         "<books>\n" +
                         "</books>"
                         );
                    fstream.Write(array, 0, array.Length);
                }
                using (var sr = new StreamReader(FilePath, Encoding.UTF8))
                    xDoc.Load(sr);
            }
        }
        private void AddNode()
        {
            foreach (KeyValuePair<string, string> keyValue in Params)
            {
                tmpNode = xDoc.CreateElement(keyValue.Key);
                tmpNode.InnerText = keyValue.Value;
                xBook.AppendChild(tmpNode);
            }
            xRoot.AppendChild(xBook);
        }
    }
}
