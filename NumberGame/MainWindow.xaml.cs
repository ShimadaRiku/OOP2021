using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace NumberGame
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {

        DispatcherTimer dt = new DispatcherTimer();
        Stopwatch sw = new Stopwatch();
        int rand = 0;
        public MainWindow()
        {
            InitializeComponent();
            random(1, 26);
            this.Title = "NumberGame タイム[00:00:000]";
            dt.Interval= new TimeSpan(0, 0, 0, 0, 1);
            dt.Tick += Dt_Tick;
            dt.Start();
            sw.Start();
        }

        private void Dt_Tick(object sender, EventArgs e)
        {
            this.Title = "NumberGame タイム[" + sw.Elapsed.ToString(@"mm\:ss\:fff") + "]";
        }

        public void random(int min,int max)
        {
            Random r1 = new System.Random();
            rand = r1.Next(min, max);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = e.Source as Button;
            button.Background = Brushes.CadetBlue;

            int select = int.Parse((string)button.Content);

            if (rand == select)
            {
                Ans.Text = "正解です";
                dt.Stop();
                sw.Stop();
            }
            else if (rand > select)
            {
                Ans.Text = select.ToString() + "より大きい数です";
            }
            else if (rand < select)
            {
                Ans.Text = select.ToString() + "小さい数です";
            }
        }   
    }
}
