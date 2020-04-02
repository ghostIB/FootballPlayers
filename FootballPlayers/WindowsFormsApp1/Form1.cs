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
    public partial class Form1 : Form
    {
        XmlDocument xDoc;
        string team;
        string FilePath="D://team.xml";
        Form2 newForm;
        public Form1()
        {
            InitializeComponent();
            if (File.Exists(FilePath))
            {
                ShowWindows();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.ForestGreen, -30, 480, 100, 100);
        }

        private void Label_Click(object sender, EventArgs e)
        {
            newForm = new Form2();
            newForm.Show();
        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
        private void ShowWindows()
        {
            xDoc = new XmlDocument();
            xDoc.Load("D://team.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlNodeList xNumbers = xRoot.ChildNodes;
            foreach (XmlElement number in xNumbers)
            {
                newForm = new Form2();
                newForm.textBox3.Text = number.Attributes[0].Value;
                foreach (XmlNode element in number.ChildNodes)
                {
                    if (element.Name == "name")
                    {
                        newForm.textBox1.Text = element.InnerText;
                    }
                    if (element.Name == "surname")
                    {
                        newForm.textBox2.Text = element.InnerText;
                    }
                    if (element.Name == "position")
                    {
                        newForm.comboBox1.Text = element.InnerText;
                    }
                }
                newForm.Show();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (!File.Exists(FilePath))
            {
                team = string.Join("", textBox1.Text.Split(' '));
                xDoc = new XmlDocument();
                using (FileStream fstream = new FileStream(FilePath, FileMode.OpenOrCreate))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(
                         "<?xml version=\"1.0\" encoding=\"ISO-8859-1\" ?>\n" +
                         $"<{team}>\n" +
                         $"</{team}>"
                         );
                    fstream.Write(array, 0, array.Length);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            FilePath = folderBrowserDialog1.SelectedPath;
        }
    }
}
