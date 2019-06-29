using AgentApplication.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AgentApplication.ViewModel.Command
{
	public class HomePageCommand : ICommand
	{
		public MainViewModel MainViewModel { get; set; }

		public HomePageCommand(MainViewModel mainViewModel)
		{
			MainViewModel = mainViewModel;
		}
		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			MainViewModel.setHomePage(new HomePage(MainViewModel.LoggedUser));
		}
	}
}
