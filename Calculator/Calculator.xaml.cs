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
		int result;
		String firstNumberS;
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
		String operation;
		String resultS;
		bool canOperation = true;
		int currentNumber = 0;
		String currentNumberS;

		public MainWindow()
		{
			InitializeComponent();
			currentNumberS = currentNumber.ToString();
			textBlock1.Text = currentNumberS;
		}

		private void Button0_Click(object sender, RoutedEventArgs e)
		{
		#region whichDigit
			if (whichDigit == 1)
			{
				digit_1 = 0;
			}
			else if (whichDigit == 2)
			{
				digit_2 = 0;
			}
			else if (whichDigit == 3)
			{
				digit_3 = 0;
			}
			else if (whichDigit == 4)
			{
				digit_4 = 0;
			}
			else if (whichDigit == 5)
			{
				digit_5 = 0;
			}
			else if (whichDigit == 6)
			{
				digit_6 = 0;
			}
			else if (whichDigit == 7)
			{
				digit_7 = 0;
			}
			else if (whichDigit == 8)
			{
				digit_8 = 0;
			}
			else if (whichDigit == 9)
			{
				digit_9 = 0;
			}
			#endregion
			whichDigit = whichDigit + 1;
			howMany = howMany + 1;
			#region currentNumber
			if (howMany == 1)
			{
				currentNumber = digit_1;
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 2)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 3)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 4)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 5)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 6)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				digit_6S = digit_6.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S + digit_9S);
				currentNumberS = currentNumber.ToString();
			}
			#endregion
			textBlock1.Text = currentNumberS;
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
		#region currentNumber
			if (howMany == 1)
			{
				currentNumber = digit_1;
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 2)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 3)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 4)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 5)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 6)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				digit_6S = digit_6.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S + digit_9S);
				currentNumberS = currentNumber.ToString();
			}
			#endregion
			textBlock1.Text = currentNumberS;
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
		#region currentNumber
			if (howMany == 1)
			{
				currentNumber = digit_1;
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 2)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 3)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 4)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 5)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 6)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				digit_6S = digit_6.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S + digit_9S);
				currentNumberS = currentNumber.ToString();
			}
			#endregion
			textBlock1.Text = currentNumberS;
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
		#region currentNumber
			if (howMany == 1)
			{
				currentNumber = digit_1;
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 2)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 3)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 4)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 5)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 6)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				digit_6S = digit_6.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S + digit_9S);
				currentNumberS = currentNumber.ToString();
			}
			#endregion
			textBlock1.Text = currentNumberS;
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
		#region currentNumber
			if (howMany == 1)
			{
				currentNumber = digit_1;
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 2)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 3)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 4)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 5)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 6)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				digit_6S = digit_6.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S + digit_9S);
				currentNumberS = currentNumber.ToString();
			}
			#endregion
			textBlock1.Text = currentNumberS;
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
		#region currentNumber
			if (howMany == 1)
			{
				currentNumber = digit_1;
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 2)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 3)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 4)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 5)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 6)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				digit_6S = digit_6.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S + digit_9S);
				currentNumberS = currentNumber.ToString();
			}
			#endregion
			textBlock1.Text = currentNumberS;
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
			#region currentNumber
			if (howMany == 1)
			{
				currentNumber = digit_1;
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 2)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 3)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 4)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 5)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 6)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				digit_6S = digit_6.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S + digit_9S);
				currentNumberS = currentNumber.ToString();
			}
			#endregion
			textBlock1.Text = currentNumberS;
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
		#region currentNumber
			if (howMany == 1)
			{
				currentNumber = digit_1;
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 2)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 3)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 4)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 5)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 6)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				digit_6S = digit_6.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S + digit_9S);
				currentNumberS = currentNumber.ToString();
			}
			#endregion
			textBlock1.Text = currentNumberS;
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
		#region currentNumber
			if (howMany == 1)
			{
				currentNumber = digit_1;
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 2)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 3)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 4)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 5)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 6)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				digit_6S = digit_6.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S + digit_9S);
				currentNumberS = currentNumber.ToString();
			}
			#endregion
			textBlock1.Text = currentNumberS;
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
		#region currentNumber
			if (howMany == 1)
			{
				currentNumber = digit_1;
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 2)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 3)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 4)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 5)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S);
				currentNumberS = currentNumber.ToString();
			}
			else if (howMany == 6)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				digit_6S = digit_6.ToString();
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S);
				currentNumberS = currentNumber.ToString();
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
				currentNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S + digit_9S);
				currentNumberS = currentNumber.ToString();
			}
			#endregion
			textBlock1.Text = currentNumberS;
		}

		private void ButtonPlus_Click(object sender, RoutedEventArgs e)
		{
			if (canOperation == true)
			{
				#region firstNumber
				if (howMany == 1)
				{
					firstNumber = digit_1;
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 2)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S);
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 3)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					digit_3S = digit_3.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S);
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 4)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					digit_3S = digit_3.ToString();
					digit_4S = digit_4.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S);
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 5)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					digit_3S = digit_3.ToString();
					digit_4S = digit_4.ToString();
					digit_5S = digit_5.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S);
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 6)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					digit_3S = digit_3.ToString();
					digit_4S = digit_4.ToString();
					digit_5S = digit_5.ToString();
					digit_6S = digit_6.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S);
					firstNumberS = firstNumber.ToString();
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
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S);
					firstNumberS = firstNumber.ToString();
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
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S);
					firstNumberS = firstNumber.ToString();
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
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S + digit_9S);
					firstNumberS = firstNumber.ToString();
				}
				#endregion
				operation = "+";
				#region reset
				whichDigit = 1;
				howMany = 0;
				digit_1 = 0;
				digit_2 = 0;
				digit_3 = 0;
				digit_4 = 0;
				digit_5 = 0;
				digit_6 = 0;
				digit_7 = 0;
				digit_8 = 0;
				digit_9 = 0;
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				digit_6S = digit_6.ToString();
				digit_7S = digit_7.ToString();
				digit_8S = digit_8.ToString();
				digit_9S = digit_9.ToString();
				#endregion
				currentNumber = 0;
				currentNumberS = currentNumber.ToString();
				textBlock1.Text = currentNumberS;
				textBlock2.Text = operation;
			}
			else
			{
				MessageBox.Show("Please click the equals sign to see the answer before you start adding.");
				textBlock1.Text = currentNumberS;
			}
			canOperation = false;
			textBlock1.Text = currentNumberS;
		}

		private void ButtonMinus_Click(object sender, RoutedEventArgs e)
		{
			if (canOperation == true)
			{
				#region firstNumber
				if (howMany == 1)
				{
					firstNumber = digit_1;
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 2)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S);
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 3)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					digit_3S = digit_3.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S);
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 4)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					digit_3S = digit_3.ToString();
					digit_4S = digit_4.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S);
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 5)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					digit_3S = digit_3.ToString();
					digit_4S = digit_4.ToString();
					digit_5S = digit_5.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S);
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 6)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					digit_3S = digit_3.ToString();
					digit_4S = digit_4.ToString();
					digit_5S = digit_5.ToString();
					digit_6S = digit_6.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S);
					firstNumberS = firstNumber.ToString();
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
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S);
					firstNumberS = firstNumber.ToString();
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
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S);
					firstNumberS = firstNumber.ToString();
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
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S + digit_9S);
					firstNumberS = firstNumber.ToString();
				}
				#endregion
				operation = "-";
				#region reset
				whichDigit = 1;
				howMany = 0;
				digit_1 = 0;
				digit_2 = 0;
				digit_3 = 0;
				digit_4 = 0;
				digit_5 = 0;
				digit_6 = 0;
				digit_7 = 0;
				digit_8 = 0;
				digit_9 = 0;
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				digit_6S = digit_6.ToString();
				digit_7S = digit_7.ToString();
				digit_8S = digit_8.ToString();
				digit_9S = digit_9.ToString();
				#endregion
				currentNumber = 0;
				currentNumberS = currentNumber.ToString();
				textBlock1.Text = currentNumberS;
				textBlock2.Text = operation;
			}
			else
			{
				MessageBox.Show("Please click the equals sign to see the answer before you start subtracting.");
				textBlock1.Text = currentNumberS;
			}
			canOperation = false;
			textBlock1.Text = currentNumberS;
		}
		private void ButtonTimes_Click(object sender, RoutedEventArgs e)
		{
			if (canOperation == true)
			{
				#region firstNumber
				if (howMany == 1)
				{
					firstNumber = digit_1;
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 2)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S);
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 3)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					digit_3S = digit_3.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S);
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 4)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					digit_3S = digit_3.ToString();
					digit_4S = digit_4.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S);
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 5)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					digit_3S = digit_3.ToString();
					digit_4S = digit_4.ToString();
					digit_5S = digit_5.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S);
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 6)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					digit_3S = digit_3.ToString();
					digit_4S = digit_4.ToString();
					digit_5S = digit_5.ToString();
					digit_6S = digit_6.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S);
					firstNumberS = firstNumber.ToString();
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
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S);
					firstNumberS = firstNumber.ToString();
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
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S);
					firstNumberS = firstNumber.ToString();
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
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S + digit_9S);
					firstNumberS = firstNumber.ToString();
				}
				#endregion
				operation = "*";
				#region reset
				whichDigit = 1;
				howMany = 0;
				digit_1 = 0;
				digit_2 = 0;
				digit_3 = 0;
				digit_4 = 0;
				digit_5 = 0;
				digit_6 = 0;
				digit_7 = 0;
				digit_8 = 0;
				digit_9 = 0;
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				digit_6S = digit_6.ToString();
				digit_7S = digit_7.ToString();
				digit_8S = digit_8.ToString();
				digit_9S = digit_9.ToString();
				#endregion
				currentNumber = 0;
				currentNumberS = currentNumber.ToString();
				textBlock1.Text = currentNumberS;
				textBlock2.Text = operation;
			}
			else
			{
				MessageBox.Show("Please click the equals sign to see the answer before you start multiplying.");
				textBlock1.Text = currentNumberS;
			}
			canOperation = false;
			textBlock1.Text = currentNumberS;
		}

		private void ButtonDivide_Click(object sender, RoutedEventArgs e)
		{
			if (canOperation == true)
			{
				#region firstNumber
				if (howMany == 1)
				{
					firstNumber = digit_1;
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 2)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S);
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 3)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					digit_3S = digit_3.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S);
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 4)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					digit_3S = digit_3.ToString();
					digit_4S = digit_4.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S);
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 5)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					digit_3S = digit_3.ToString();
					digit_4S = digit_4.ToString();
					digit_5S = digit_5.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S);
					firstNumberS = firstNumber.ToString();
				}
				else if (howMany == 6)
				{
					digit_1S = digit_1.ToString();
					digit_2S = digit_2.ToString();
					digit_3S = digit_3.ToString();
					digit_4S = digit_4.ToString();
					digit_5S = digit_5.ToString();
					digit_6S = digit_6.ToString();
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S);
					firstNumberS = firstNumber.ToString();
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
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S);
					firstNumberS = firstNumber.ToString();
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
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S);
					firstNumberS = firstNumber.ToString();
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
					firstNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S + digit_9S);
					firstNumberS = firstNumber.ToString();
				}
				#endregion
				operation = "/";
				#region reset
				whichDigit = 1;
				howMany = 0;
				digit_1 = 0;
				digit_2 = 0;
				digit_3 = 0;
				digit_4 = 0;
				digit_5 = 0;
				digit_6 = 0;
				digit_7 = 0;
				digit_8 = 0;
				digit_9 = 0;
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				digit_6S = digit_6.ToString();
				digit_7S = digit_7.ToString();
				digit_8S = digit_8.ToString();
				digit_9S = digit_9.ToString();
				#endregion
				currentNumber = 0;
				currentNumberS = currentNumber.ToString();
				textBlock1.Text = currentNumberS;
				textBlock2.Text = operation;
			}
			else
			{
				MessageBox.Show("Please click the equals sign to see the answer before you start dividing.");
				textBlock1.Text = currentNumberS;
			}
			canOperation = false;
			textBlock1.Text = currentNumberS;
		}

		private void ButtonEquals_Click(object sender, RoutedEventArgs e)
		{
		#region secondNumber
			if (howMany == 1)
			{
				secondNumber = digit_1;
				secondNumberS = secondNumber.ToString();
			}
			else if (howMany == 2)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				secondNumber = Int32.Parse(digit_1S + digit_2S);
				secondNumberS = secondNumber.ToString();
			}
			else if (howMany == 3)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				secondNumber = Int32.Parse(digit_1S + digit_2S + digit_3S);
				secondNumberS = secondNumber.ToString();
			}
			else if (howMany == 4)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				secondNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S);
				secondNumberS = secondNumber.ToString();
			}
			else if (howMany == 5)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				secondNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S);
				secondNumberS = secondNumber.ToString();
			}
			else if (howMany == 6)
			{
				digit_1S = digit_1.ToString();
				digit_2S = digit_2.ToString();
				digit_3S = digit_3.ToString();
				digit_4S = digit_4.ToString();
				digit_5S = digit_5.ToString();
				digit_6S = digit_6.ToString();
				secondNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S);
				secondNumberS = secondNumber.ToString();
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
				secondNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S);
				secondNumberS = secondNumber.ToString();
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
				secondNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S);
				secondNumberS = secondNumber.ToString();
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
				secondNumber = Int32.Parse(digit_1S + digit_2S + digit_3S + digit_4S + digit_5S + digit_6S + digit_7S + digit_8S + digit_9S);
				secondNumberS = secondNumber.ToString();
			}
			#endregion
			if (operation == "+")
			{
				result = firstNumber + secondNumber;
				resultS = result.ToString();
				textBlock1.Text = currentNumberS;
			}
			else if (operation == "-")
			{
				result = firstNumber - secondNumber;
				resultS = result.ToString();
				textBlock1.Text = currentNumberS;
			}
			else if (operation == "*")
			{
				result = firstNumber * secondNumber;
				resultS = result.ToString();
				textBlock1.Text = currentNumberS;
			}
			else if (operation == "/")
			{
				result = firstNumber / secondNumber;
				resultS = result.ToString();
				textBlock1.Text = currentNumberS;
			}
			currentNumber = result;
			currentNumberS = currentNumber.ToString();
			#region reset
			whichDigit = 1;
			howMany = 0;
			digit_1 = 0;
			digit_2 = 0;
			digit_3 = 0;
			digit_4 = 0;
			digit_5 = 0;
			digit_6 = 0;
			digit_7 = 0;
			digit_8 = 0;
			digit_9 = 0;
			digit_1S = digit_1.ToString();
			digit_2S = digit_2.ToString();
			digit_3S = digit_3.ToString();
			digit_4S = digit_4.ToString();
			digit_5S = digit_5.ToString();
			digit_6S = digit_6.ToString();
			digit_7S = digit_7.ToString();
			digit_8S = digit_8.ToString();
			digit_9S = digit_9.ToString();
			#endregion
			firstNumber = result;
			canOperation = true;
			textBlock1.Text = currentNumberS;
		}

		private void ButtonClear_Click(object sender, RoutedEventArgs e)
		{
		#region reset
			whichDigit = 1;
			howMany = 0;
			digit_1 = 0;
			digit_2 = 0;
			digit_3 = 0;
			digit_4 = 0;
			digit_5 = 0;
			digit_6 = 0;
			digit_7 = 0;
			digit_8 = 0;
			digit_9 = 0;
			digit_1S = digit_1.ToString();
			digit_2S = digit_2.ToString();
			digit_3S = digit_3.ToString();
			digit_4S = digit_4.ToString();
			digit_5S = digit_5.ToString();
			digit_6S = digit_6.ToString();
			digit_7S = digit_7.ToString();
			digit_8S = digit_8.ToString();
			digit_9S = digit_9.ToString();
			#endregion
			currentNumber = result;
			currentNumberS = currentNumber.ToString();
			textBlock1.Text = currentNumberS;
		}

		private void ButtonRestart_Click(object sender, RoutedEventArgs e)
		{
		#region reset
			whichDigit = 1;
			howMany = 0;
			digit_1 = 0;
			digit_2 = 0;
			digit_3 = 0;
			digit_4 = 0;
			digit_5 = 0;
			digit_6 = 0;
			digit_7 = 0;
			digit_8 = 0;
			digit_9 = 0;
			digit_1S = digit_1.ToString();
			digit_2S = digit_2.ToString();
			digit_3S = digit_3.ToString();
			digit_4S = digit_4.ToString();
			digit_5S = digit_5.ToString();
			digit_6S = digit_6.ToString();
			digit_7S = digit_7.ToString();
			digit_8S = digit_8.ToString();
			digit_9S = digit_9.ToString();
			#endregion
			firstNumber = 0;
			secondNumber = 0;
			firstNumberS = firstNumber.ToString();
			secondNumberS = secondNumber.ToString();
			operation = "";
			result = 0;
			resultS = result.ToString();
			currentNumber = result;
			currentNumberS = currentNumber.ToString();
			textBlock1.Text = currentNumberS;
			textBlock2.Text = operation;
		}
	}
}
