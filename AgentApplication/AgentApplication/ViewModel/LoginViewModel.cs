using AgentApplication.Model;
using AgentApplication.View;
using AgentApplication.ViewModel.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentApplication.ViewModel
{
	public class LoginViewModel : ViewModelBase
	{
		private string username;
		private string lblVisible;

		private Service.UserService userService = new Service.UserService();
				
		public LoginCommand LoginCommand { get; set; }

		private bool? dialogResult;


		public LoginViewModel()
		{
			LblVisible = "Hidden";
			LoginCommand = new LoginCommand(this);
		}

		public string TxtUsername
		{
			get { return username; } 
			set
			{
				username = value;
				LblVisible = "Hidden";
				OnPropertyChanged("TxtUsername");
			}
		}

		public bool? DialogResult
		{
			get
			{
				return dialogResult;
			}

			set
			{
				dialogResult = value;
				OnPropertyChanged();
			}
		}

		public string LblVisible {
			get => lblVisible;
			set
			{
				lblVisible = value;
				OnPropertyChanged("LblVisible");
			}
		}

		public void loginMethod(string password)
		{
			if (userService.LoginUser(username, password) != null)
			{
				MainWindow mw = new MainWindow(userService.LoginUser(username, password));
				mw.Show();
				DialogResult = true;
			}
			else
			{
				LblVisible = "Visible";

			}
		}
	}
}
