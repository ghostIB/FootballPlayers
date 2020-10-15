using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        static MediaPlayer player = new MediaPlayer();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Move(object sender, MouseEventArgs e)
        {
            double Image_Width = this.Width - ((Image)sender).Margin.Left - ((Image)sender).Margin.Right;
            double Image_Height = this.Height - ((Image)sender).Margin.Top - ((Image)sender).Margin.Bottom;
            if ((int)e.LeftButton==1)
            {
                ((Image)sender).Margin = new Thickness(e.GetPosition(this).X-Image_Width/2,e.GetPosition(this).Y-Image_Height/2,wind.Width-e.GetPosition(this).X-Image_Width/2, wind.Height - e.GetPosition(this).Y - Image_Height / 2);
            }
        }
        private void CheckAnswers(object sender, RoutedEventArgs e)
        {
            bool condition1 = canv1.Margin.Left < img1.Margin.Left && canv1.Margin.Top < img1.Margin.Top && canv1.Margin.Right < img1.Margin.Right && canv1.Margin.Bottom < img1.Margin.Bottom;
            bool condition2 = canv2.Margin.Left < img2.Margin.Left && canv2.Margin.Top < img2.Margin.Top && canv2.Margin.Right < img2.Margin.Right && canv2.Margin.Bottom < img2.Margin.Bottom;
            bool condition3 = canv3.Margin.Left < img3.Margin.Left && canv3.Margin.Top < img3.Margin.Top && canv3.Margin.Right < img3.Margin.Right && canv3.Margin.Bottom < img3.Margin.Bottom;
            if (condition1 && condition2 && condition3)
            {
                player.Open(new Uri("C:\\Users\\user\\Downloads\\right.mp3"));
                player.Play();
                MessageBox.Show("Молодец");
                Close();
            }
            else
            {
                player.Open(new Uri("C:\\Users\\user\\Downloads\\mistake.mp3"));
                player.Play();
            }
        }
    }
}
