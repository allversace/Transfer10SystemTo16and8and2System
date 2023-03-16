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

namespace WpfApp7
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            result16.IsReadOnly = true;
            result8.IsReadOnly = true;
            result2.IsReadOnly = true;
            a10.MaxLength = 2;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
                if (a10.Text != "")
                {
                    int aTen = Convert.ToInt32(a10.Text);
                    int a16, a8, a2;
                    string a166;
                    
                    if(aTen <= 15)
                    {
                        switch (aTen)
                        {
                            case 0:
                            a16 = 0;
                            a8 = 0;
                            a2 = 0;
                            result16.Text = a16.ToString();
                            result8.Text = a8.ToString();
                            result2.Text = a2.ToString();
                            break;
                            case 1:
                            a16 = 1;
                            a8 = 1;
                            a2 = 1;
                            result16.Text = a16.ToString();
                            result8.Text = a8.ToString();
                            result2.Text = a2.ToString();
                            break;
                            case 2:
                            a16 = 2;
                            a8 = 2;
                            a2 = 10;
                            result16.Text = a16.ToString();
                            result8.Text = a8.ToString();
                            result2.Text = a2.ToString();
                            break;
                            case 3:
                            a16 = 3;
                            a8 = 3;
                            a2 = 11;
                            result16.Text = a16.ToString();
                            result8.Text = a8.ToString();
                            result2.Text = a2.ToString();
                            break;
                            case 4:
                            a16 = 4;
                            a8 = 4;
                            a2 = 100;
                            result16.Text = a16.ToString();
                            result8.Text = a8.ToString();
                            result2.Text = a2.ToString();
                            break;
                            case 5:
                            a16 = 5;
                            a8 = 5;
                            a2 = 101;
                            result16.Text = a16.ToString();
                            result8.Text = a8.ToString();
                            result2.Text = a2.ToString();
                            break;
                            case 6:
                            a16 = 6;
                            a8 = 6;
                            a2 = 110;
                            result16.Text = a16.ToString();
                            result8.Text = a8.ToString();
                            result2.Text = a2.ToString();
                            break;
                            case 7:
                            a16 = 7;
                            a8 = 7;
                            a2 = 111;
                            result16.Text = a16.ToString();
                            result8.Text = a8.ToString();
                            result2.Text = a2.ToString();
                            break;
                            case 8:
                            a16 = 8;
                            a8 = 10;
                            a2 = 1000;
                            result16.Text = a16.ToString();
                            result8.Text = a8.ToString();
                            result2.Text = a2.ToString();
                            break;
                            case 9:
                            a16 = 9;
                            a8 = 11;
                            a2 = 1001;
                            result16.Text = a16.ToString();
                            result8.Text = a8.ToString();
                            result2.Text = a2.ToString();
                            break;
                            case 10:
                            a166 = "A";
                            a8 = 12;
                            a2 = 1010;
                            result16.Text = a166.ToString();
                            result8.Text = a8.ToString();
                            result2.Text = a2.ToString();
                            break;
                            case 11:
                            a166 = "B";
                            a8 = 13;
                            a2 = 1011;
                            result16.Text = a166.ToString();
                            result8.Text = a8.ToString();
                            result2.Text = a2.ToString();
                            break;
                            case 12:
                            a166 = "C";
                            a8 = 14;
                            a2 = 1100;
                            result16.Text = a166.ToString();
                            result8.Text = a8.ToString();
                            result2.Text = a2.ToString();
                            break;
                            case 13:
                            a166 = "D";
                            a8 = 15;
                            a2 = 1101;
                            result16.Text = a166.ToString();
                            result8.Text = a8.ToString();
                            result2.Text = a2.ToString();
                            break;
                            case 14:
                            a166 = "E";
                            a8 = 16;
                            a2 = 1110;
                            result16.Text = a166.ToString();
                            result8.Text = a8.ToString();
                            result2.Text = a2.ToString();
                            break;
                            case 15:
                            a166 = "F";
                            a8 = 17;
                            a2 = 1111;
                            result16.Text = a166.ToString();
                            result8.Text = a8.ToString();
                            result2.Text = a2.ToString();
                            break;
                        }
                    }
                    else
                    {
                    MessageBox.Show("Error x02");
                    }                    
                }
                else
                {
                    MessageBox.Show("Error x01");
                }
        }

        private void a10_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!Char.IsDigit(e.Text, 0)) e.Handled = true;
        }
    }
}
