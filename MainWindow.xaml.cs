using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace messangerChat
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		private void for_username_GotFocus(object sender, RoutedEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null && textBox.Text == "enter your username")
			{
				textBox.Text = "";
			}
		}

		private void for_address_GotFocus(object sender, RoutedEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null && textBox.Text == "enter your IP address")
			{
				textBox.Text = "";
			}
		}

		private void for_address_PreviewTextInput(object sender, TextCompositionEventArgs e)
		{
			TextBox textBox = sender as TextBox;
			if (textBox != null)
			{
				if (textBox.Text.Length == 2 || textBox.Text.Length == 6 || textBox.Text.Length == 7 || textBox.Text.Length == 9)
				{
					textBox.Text += ".";
					textBox.CaretIndex = textBox.Text.Length;
				}
				if (textBox.Text.Length >= 12)
				{
					e.Handled = true;
				}
			}
		}
	}
}