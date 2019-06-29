using AgentApplication.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AgentApplication.ViewModel.Command
{
	public class AccommodationProfileCommand : ICommand
	{
		public MainViewModel MainViewModel { get; set; }

		public AccommodationProfileCommand(MainViewModel mainViewModel)
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
			Console.WriteLine("accCommand execute");
			MainViewModel.setAccommodationProfilePage(new AccommodationProfile(MainViewModel.LoggedUser));
		}
	}
}
