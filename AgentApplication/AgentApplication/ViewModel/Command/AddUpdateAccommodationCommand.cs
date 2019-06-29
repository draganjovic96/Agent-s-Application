﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace AgentApplication.ViewModel.Command
{
	public class AddUpdateAccommodationCommand : ICommand
	{
		public AccommodationViewModel accommodationViewModel { get; set; }

		public AddUpdateAccommodationCommand(AccommodationViewModel accommodationViewModel)
		{
			this.accommodationViewModel = accommodationViewModel;
		}

		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			accommodationViewModel.AddOrUpdateAccommodation();
		}
	}
}
