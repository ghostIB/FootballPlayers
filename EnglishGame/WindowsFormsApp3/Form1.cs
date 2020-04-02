using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        private bool mouse1 = false;
        private bool mouse2 = false;
        private bool mouse3 = false;
        private int score = 0;
        private int time = 0;
        private Dictionary<PictureBox, Panel> data;
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedItem="1";
            progressBar1.Value = 100;
            data = new Dictionary<PictureBox, Panel>()
            {
                {pictureBox1,panel1 },
                {pictureBox2,panel2 },
                {pictureBox3,panel3 },
            };
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Panel_Hover(object sender, EventArgs e)
        {
            IsInPanel(pictureBox1, panel1);
        }

        private void Panel2_Hover(object sender, EventArgs e)
        {
            IsInPanel(pictureBox2, panel2);
        }

        private void MouseDown1(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
            mouse1 = true;
        }

        private void MouseMove1(object sender, MouseEventArgs e)
        {
            Control c1 = sender as Control;
            if (mouse1)
            {
                c1.Location = this.PointToClient(Control.MousePosition);
            }
        }

        private void MouseUp1(object sender, MouseEventArgs e)
        {
            mouse1 = false;
        }

        private void MouseDown2(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
            mouse2 = true;
        }

        private void MouseMove2(object sender, MouseEventArgs e)
        {
            Control c2 = sender as Control;
            if (mouse2)
            {
                c2.Location = this.PointToClient(Control.MousePosition);
            }
        }

        private void MouseUp2(object sender, MouseEventArgs e)
        {
            mouse2 = false;
        }

        private void MouseMove3(object sender, MouseEventArgs e)
        {
            Control c3 = sender as Control;
            if (mouse3)
            {
                c3.Location = this.PointToClient(Control.MousePosition);
            }
        }

        private void MouseUp3(object sender, MouseEventArgs e)
        {
            mouse3 = false;
        }

        private void MouseDown3(object sender, MouseEventArgs e)
        {
            timer1.Enabled = true;
            mouse3 = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void Timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar1.Value --;
            time++;
            if (progressBar1.Value==1)
            {
                timer1.Enabled = false;
                MessageBox.Show($"Ваш счет: {score / time * 100}");
                Close();
            }
        }
        public static bool IsInPanel(PictureBox TImage, Panel TShape)
        {
            if (TImage.Left >= TShape.Left && TImage.Left + TImage.Width <= TShape.Left + TShape.Width && TImage.Top >= TShape.Top && TImage.Top + TImage.Height <= TShape.Top + TShape.Height)
            {
                return true;
            }
            else return false;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            foreach (KeyValuePair<PictureBox,Panel> keyValue in data)
            {
                if (IsInPanel(keyValue.Key,keyValue.Value))
                {
                    score++;
                }
            }
            MessageBox.Show($"Ваш счет: {score*1000/time}");
            Close();
        }
    }
}
