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

namespace Calculator
{

	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		int digit_1;
		int digit_2;
		int digit_3;
		int digit_4;
		int digit_5;
		int digit_6;
		int digit_7;
		int digit_8;
		int digit_9;
		int whichDigit = 1;
		int howMany = 0;
		int firstNumber;
		int secondNumber;
		String firstNumerS;
		String secondNumberS;
		String digit_1S;
		String digit_2S;
		String digit_3S;
		String digit_4S;
		String digit_5S;
		String digit_6S;
		String digit_7S;
		String digit_8S;
		String digit_9S;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void Button1_Click(object sender, RoutedEventArgs e)
		{
		#region whichDigit
			if (whichDigit == 1)
			{
				digit_1 = 1;
			}
			else if (whichDigit == 2)
			{
				digit_2 = 1;
			}
			else if (whichDigit == 3)
			{
				digit_3 = 1;
			}
			else if (whichDigit == 4)
			{
				digit_4 = 1;
			}
			else if (whichDigit == 5)
			{
				digit_5 = 1;
			}
			else if (whichDigit == 6)
			{
				digit_6 = 1;
			}
			else if (whichDigit == 7)
			{
				digit_7 = 1;
			}
			else if (whichDigit == 8)
			{
				digit_8 = 1;
			}
			else if (whichDigit == 9)
			{
				digit_9 = 1;
			}
			#endregion
			whichDigit = whichDigit + 1;
			howMany = howMany + 1;
		}

		private void Button2_Click(object sender, RoutedEventArgs e)
		{
		#region whichDigit
			if (whichDigit == 1)
			{
				digit_1 = 2;
			}
			else if (whichDigit == 2)
			{
				digit_2 = 2;
			}
			else if (whichDigit == 3)
			{
				digit_3 = 2;
			}
			else if (whichDigit == 4)
			{
				digit_4 = 2;
			}
			else if (whichDigit == 5)
			{
				digit_5 = 2;
			}
			else if (whichDigit == 6)
			{
				digit_6 = 2;
			}
			else if (whichDigit == 7)
			{
				digit_7 = 2;
			}
			else if (whichDigit == 8)
			{
				digit_8 = 2;
			}
			else if (whichDigit == 9)
			{
				digit_9 = 2;
			}
			#endregion
			whichDigit = whichDigit + 1;
			howMany = howMany + 1;
		}

		private void Button3_Click(object sender, RoutedEventArgs e)
		{
		#region whichDigit
			if (whichDigit == 1)
			{
				digit_1 = 3;
			}
			else if (whichDigit == 2)
			{
				digit_2 = 3;
			}
			else if (whichDigit == 3)
			{
				digit_3 = 3;
			}
			else if (whichDigit == 4)
			{
				digit_4 = 3;
			}
			else if (whichDigit == 5)
			{
				digit_5 = 3;
			}
			else if (whichDigit == 6)
			{
				digit_6 = 3;
			}
			else if (whichDigit == 7)
			{
				digit_7 = 3;
			}
			else if (whichDigit == 8)
			{
				digit_8 = 3;
			}
			else if (whichDigit == 9)
			{
				digit_9 = 3;
			}
			#endregion
			whichDigit = whichDigit + 1;
			howMany = howMany + 1;
		}

		private void Button4_Click(object sender, RoutedEventArgs e)
		{
		#region whichDigit
			if (whichDigit == 1)
			{
				digit_1 = 4;
			}
			else if (whichDigit == 2)
			{
				digit_2 = 4;
			}
			else if (whichDigit == 3)
			{
				digit_3 = 4;
			}
			else if (whichDigit == 4)
			{
				digit_4 = 4;
			}
			else if (whichDigit == 5)
			{
				digit_5 = 4;
			}
			else if (whichDigit == 6)
			{
				digit_6 = 4;
			}
			else if (whichDigit == 7)
			{
				digit_7 = 4;
			}
			else if (whichDigit == 8)
			{
				digit_8 = 4;
			}
			else if (whichDigit == 9)
			{
				digit_9 = 4;
			}
			#endregion
			whichDigit = whichDigit + 1;
			howMany = howMany + 1;
		}

		private void Button5_Click(object sender, RoutedEventArgs e)
		{
		#region whichDigit
			if (whichDigit == 1)
			{
				digit_1 = 5;
			}
			else if (whichDigit == 2)
			{
				digit_2 = 5;
			}
			else if (whichDigit == 3)
			{
				digit_3 = 5;
			}
			else if (whichDigit == 4)
			{
				digit_4 = 5;
			}
			else if (whichDigit == 5)
			{
				digit_5 = 5;
			}
			else if (whichDigit == 6)
			{
				digit_6 = 5;
			}
			else if (whichDigit == 7)
			{
				digit_7 = 5;
			}
			else if (whichDigit == 8)
			{
				digit_8 = 5;
			}
			else if (whichDigit == 9)
			{
				digit_9 = 5;
			}
			#endregion
			whichDigit = whichDigit + 1;
			howMany = howMany + 1;
		}

		private void Button6_Click(object sender, RoutedEventArgs e)
		{
		#region whichDigit
			if (whichDigit == 1)
			{
				digit_1 = 6;
			}
			else if (whichDigit == 2)
			{
				digit_2 = 6;
			}
			else if (whichDigit == 3)
			{
				digit_3 = 6;
			}
			else if (whichDigit == 4)
			{
				digit_4 = 6;
			}
			else if (whichDigit == 5)
			{
				digit_5 = 6;
			}
			else if (whichDigit == 6)
			{
				digit_6 = 6;
			}
			else if (whichDigit == 7)
			{
				digit_7 = 6;
			}
			else if (whichDigit == 8)
			{
				digit_8 = 6;
			}
			else if (whichDigit == 9)
			{
				digit_9 = 6;
			}
			#endregion
			whichDigit = whichDigit + 1;
			howMany = howMany + 1;
		}

		private void Button7_Click(object sender, RoutedEventArgs e)
		{
		#region whichDigit
			if (whichDigit == 1)
			{
				digit_1 = 7;
			}
			else if (whichDigit == 2)
			{
				digit_2 = 7;
			}
			else if (whichDigit == 3)
			{
				digit_3 = 7;
			}
			else if (whichDigit == 4)
			{
				digit_4 = 7;
			}
			else if (whichDigit == 5)
			{
				digit_5 = 7;
			}
			else if (whichDigit == 6)
			{
				digit_6 = 7;
			}
			else if (whichDigit == 7)
			{
				digit_7 = 7;
			}
			else if (whichDigit == 8)
			{
				digit_8 = 7;
			}
			else if (whichDigit == 9)
			{
				digit_9 = 7;
			}
			#endregion
			whichDigit = whichDigit + 1;
			howMany = howMany + 1;
		}

		private void Button8_Click(object sender, RoutedEventArgs e)
		{
		#region whichDigit
			if (whichDigit == 1)
			{
				digit_1 = 8;
			}
			else if (whichDigit == 2)
			{
				digit_2 = 8;
			}
			else if (whichDigit == 3)
			{
				digit_3 = 8;
			}
			else if (whichDigit == 4)
			{
				digit_4 = 8;
			}
			else if (whichDigit == 5)
			{
				digit_5 = 8;
			}
			else if (whichDigit == 6)
			{
				digit_6 = 8;
			}
			else if (whichDigit == 7)
			{
				digit_7 = 8;
			}
			else if (whichDigit == 8)
			{
				digit_8 = 8;
			}
			else if (whichDigit == 9)
			{
				digit_9 = 8;
			}
			#endregion
			whichDigit = whichDigit + 1;
			howMany = howMany + 1;
		}

		private void Button9_Click(object sender, RoutedEventArgs e)
		{
		#region whichDigit
			if (whichDigit == 1)
			{
				digit_1 = 9;
			}
			else if (whichDigit == 2)
			{
				digit_2 = 9;
			}
			else if (whichDigit == 3)
			{
				digit_3 = 9;
			}
			else if (whichDigit == 4)
			{
				digit_4 = 9;
			}
			else if (whichDigit == 5)
			{
				digit_5 = 9;
			}
			else if (whichDigit == 6)
			{
				digit_6 = 9;
			}
			else if (whichDigit == 7)
			{
				digit_7 = 9;
			}
			else if (whichDigit == 8)
			{
				digit_8 = 9;
			}
			else if (whichDigit == 9)
			{
				digit_9 = 9;
			}
			#endregion
			whichDigit = whichDigit + 1;
			howMany = howMany + 1;
		}

		private void ButtonPlus_Click(object sender, RoutedEventArgs e)
		{
			if (howMany == 1)
			{
				firstNumber = digit_1;
			}
			else if (howMany == 2)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				firstNumber = Int32.Parse(digit_1S + digit_2S);
				firstNumerS = firstNumber.ToString();
			}
			else if (howMany == 3)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				firstNumer = Int32.Parse(digit_1S + digit_2S + digit_3S);
				firstNumerS = firstNumber.ToString();
			}
			else if (howMany == 4)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				firstNumer = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S);
				firstNumerS = firstNumber.ToString();
			}
			else if (howMany == 5)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				firstNumer = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S);
				firstNumerS = firstNumber.ToString();
			}
			else if (howMany == 6)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				digit_6S = digit_6.ToString();
				firstNumer = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S);
				firstNumerS = firstNumber.ToString();
			}
			else if (howMany == 7)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				digit_6S = digit_6.ToString();
				digit_7S = digit_7.ToString();
				firstNumer = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S);
				firstNumerS = firstNumber.ToString();
			}
			else if (howMany == 8)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				digit_6S = digit_6.ToString();
				digit_7S = digit_7.ToString();
				digit_8S = digit_8.ToString();
				firstNumer = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S);
				firstNumerS = firstNumber.ToString();
			}
			else if (howMany == 9)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				digit_6S = digit_6.ToString();
				digit_7S = digit_7.ToString();
				digit_8S = digit_8.ToString();
				digit_9S = digit_9.ToString();
				firstNumer = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S + digit_9S);
				firstNumerS = firstNumber.ToString();
			}
			
		}

		private void ButtonMinus_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Minus");
		}

		private void ButtonTimes_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Times");
		}

		private void ButtonDivide_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Divide");
		}

		private void ButtonEquals_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Equals");
		}
	}
}
