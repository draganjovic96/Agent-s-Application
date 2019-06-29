using AgentApplication.AccommodationService;
using AgentApplication.Model;
using AgentApplication.UserService;
using AgentApplication.ViewModel;
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
using System.Windows.Shapes;

namespace AgentApplication.View
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public static User LoggedUser { get; set; }

		public MainWindow(User User)
		{
			Console.WriteLine(User.id + " " + User.name + " " + User.username);
			InitializeComponent();
			LoggedUser = User;
			DataContext = new MainViewModel(User);
		}
	}
}
