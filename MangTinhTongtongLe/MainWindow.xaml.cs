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

namespace MangTinhTongtongLe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double s = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        int Tong(int [] n)
        {
            int tong = 0;
            for (int i = 0; i < n.Length; i++)
            {
                tong += n[i];
            }
            return tong;
        }
        int TongLe(int[] n)
        {
            int tongle = 0;
            for(int i = 0; i < n.Length; i++)
            {
                if (n[i] % 2 != 0)
                    tongle += n[i];
            }
            return tongle;
        }
        private void BtnTong_Click(object sender, RoutedEventArgs e)
        {           
            int [] n =  { 7, 5, 6, 9, 3 };
            txtketqua.Text = Tong(n).ToString();
        }

        private void BtnTongLe_Click(object sender, RoutedEventArgs e)
        {
            int [] n = { 7, 5, 6, 9, 3 };
            txtketqua.Text = TongLe(n).ToString();
        }
    }
}
