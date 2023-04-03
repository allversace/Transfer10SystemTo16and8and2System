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
public static class ErrorStrings
{
public static string EmptyString = "Пустая строка!";
public static string ErrorType = "Неверный тип!";
public static string Overflow = "Переполнение!";
public static string NegativeNumber = "Число отрицательное!";
}

public partial class MainWindow : Window
{
public MainWindow()
{
InitializeComponent();
}

private void BinaryButton_Click(object sender, RoutedEventArgs e) => checkNumber(Number.Text, 2);

private void OctalButton_Click(object sender, RoutedEventArgs e) => checkNumber(Number.Text, 8);

private void HexButton_Click(object sender, RoutedEventArgs e) => checkNumber(Number.Text, 16);

public void checkNumber(string number, int type)
{
if (number != "")
{
try
{
Result.Text = Convert.ToString(int.Parse(number), type);
}
catch (FormatException)
{
showError(ErrorStrings.ErrorType);
}
catch (OverflowException)
{
showError(ErrorStrings.Overflow);
}
}
else
{
showError(ErrorStrings.EmptyString);
}
}

private void showError(string message)
{
MessageBox.Show(message, "", MessageBoxButton.OK, MessageBoxImage.Error);
}
}
}
