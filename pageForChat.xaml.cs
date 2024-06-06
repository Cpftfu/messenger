using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
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

namespace messangerChat
{
	/// <summary>
	/// Логика взаимодействия для pageForChat.xaml
	/// </summary>
	public partial class pageForChat : Page
	{
		List<Socket> users = new List<Socket>();
		Socket socket;

		public pageForChat()
		{
			InitializeComponent();
			socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			/*socket.Connect("26.80.234.197", 4000);*/
			ReceiveMessage();
		}

		private async void ReceiveMessage()
		{
			while (true)
			{
				byte[] bytes = new byte[1024];
				await socket.ReceiveAsync(bytes, SocketFlags.None);
				string message = Encoding.UTF8.GetString(bytes);

				listBox.Items.Add(message);
			}
		}

		private async void SendMessage(string message)
		{
			byte[] bytes = Encoding.UTF8.GetBytes(message);
			await socket.SendAsync(bytes, SocketFlags.None);
		}

		private void button_Click(object sender, RoutedEventArgs e)
		{
			SendMessage(text.Text);
		}
	}
}
