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

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        private XmlDocument xDoc;
        private XmlElement xRoot;
        private XmlElement xNumber;
        private Image img;
        private Bitmap bitmap;
        private string FilePath="D://team.xml";
        private int limit=0;
        private Dictionary<string,string> Params;
        private int number;
        private XmlElement tmpNode;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            img = Image.FromStream(openFileDialog1.OpenFile());
            pictureBox1.Image = img;
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {
            
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (img != null)
            {
                bitmap = new Bitmap(img);
            }
                Params = new Dictionary<string, string> { { "name", textBox1.Text.ToLower() }, { "surname", textBox2.Text.ToLower() }, { "position", comboBox1.Text.ToLower() } };
            SaveFile();
        }
        private void SaveFile()
        {
            limit++;
            if (limit>1)
            {
                return ;
            }
            xDoc = new XmlDocument();
            xDoc.Load(FilePath);
            xRoot = xDoc.DocumentElement;
            xNumber = xDoc.CreateElement("number");
            xNumber.SetAttribute("num",number.ToString());
            foreach (KeyValuePair<string, string> keyValue in Params)
            {
                tmpNode = xDoc.CreateElement(keyValue.Key);
                tmpNode.InnerText = keyValue.Value;
                xNumber.AppendChild(tmpNode);
            }
            xRoot.AppendChild(xNumber);
            xDoc.Save(FilePath);
        }
        private void Form1_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            SaveFile();
        }

        private void Number_Change(object sender, EventArgs e)
        {
            try
            {
                number = int.Parse(textBox3.Text);
            }
            catch
            {
                MessageBox.Show("Надо ввести число");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xDoc = new XmlDocument();
            xDoc.Load(FilePath);
            xRoot = xDoc.DocumentElement;
            foreach (XmlElement elem in xRoot.ChildNodes)
            {
                if (elem.GetAttribute("num")==textBox3.Text)
                {
                    xRoot.RemoveChild(elem);
                }
            }
            xDoc.Save(FilePath);
            this.Close();
        }
    }

}
