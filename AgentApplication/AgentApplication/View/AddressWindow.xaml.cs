using AgentApplication.Model;
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
	/// Interaction logic for Address.xaml
	/// </summary>
	public partial class AddressWindow : Window
	{
		public AddressWindow(Address address)
		{
			InitializeComponent();
			DataContext = new AddressViewModel(address);
		}
	}
}
