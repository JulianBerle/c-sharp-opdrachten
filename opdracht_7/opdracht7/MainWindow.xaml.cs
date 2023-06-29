using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace MovingButtonWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            btnMoveMe.MouseMove += BtnMoveMe_MouseMove;
            btnMoveMe.Click += BtnMoveMe_Click;
        }

        private void BtnMoveMe_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            Random r = new Random();

            int w = r.Next(0, (int)MyGrid.ActualWidth - (int)btn.ActualWidth);
            int t = r.Next(0, (int)MyGrid.ActualHeight - (int)btn.ActualHeight);

            btnMoveMe.MouseMove -= BtnMoveMe_MouseMove;

            Thickness th = new Thickness(w, t, 0, 0);
            btn.Margin = th;

            Task.Delay(500).ContinueWith(_ =>
            {
                Dispatcher.Invoke(() =>
                {
                    btn.Margin = new Thickness();
                    btnMoveMe.MouseMove += BtnMoveMe_MouseMove;
                });
            });
        }

        private void BtnMoveMe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Je hebt me te pakken!");
        }
    }
}
