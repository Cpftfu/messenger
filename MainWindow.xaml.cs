using System.Text;
using System.Net;
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

		private bool ValidateUserName(string userName)
		{
			if (userName == "enter your username" || string.IsNullOrEmpty(userName))
			{
				MessageBox.Show("please enter a valid username");
				return false;
			}
			return true;
		}

		private bool ValidateIpAddress(string ipAddress)
		{
			if (!IPAddress.TryParse(ipAddress, out _))
			{
				MessageBox.Show("please enter a valid IP address");
				return false;
			}
			return true;
		}

		private void for_connect_Click(object sender, RoutedEventArgs e)
		{
			if (ValidateUserName(for_username.Text) && ValidateIpAddress(for_address.Text))
			{
				// Логика для подключения к существующему чату
				//MessageBox.Show("connected to existing chat!");
				for_chat_frame.Content = new pageForChat();
			}
		}

		private void for_create_Click(object sender, RoutedEventArgs e)
		{
			if (ValidateUserName(for_username.Text))
			{
				// Логика для создания нового чата
				MessageBox.Show("chat is created!");
				//for_chat_frame.Content = new pageForChat();
			}
		}
	}
}