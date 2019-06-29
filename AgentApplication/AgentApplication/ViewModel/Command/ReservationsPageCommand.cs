using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AgentApplication.ViewModel.Command
{
	public class ReservationsPageCommand : ICommand
	{
		public HomePageViewModel UnitsModelView { get; set; }

		public ReservationsPageCommand(HomePageViewModel unitsModelView)
		{
			UnitsModelView = unitsModelView;
		}

		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			UnitsModelView.setReservationsPage();
		}
	}
}
