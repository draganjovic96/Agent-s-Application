using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace AgentApplication.ViewModel.Command
{
	public class LoginCommand : ICommand
	{
		public LoginViewModel UserModelView { get; set; } 

		public LoginCommand(LoginViewModel userModelView) {
			this.UserModelView = userModelView;
		}

		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			return true;
		}

		public void Execute(object parameter)
		{
			var passwordBox = parameter as PasswordBox;
			string password = passwordBox.Password;
			UserModelView.loginMethod(password);
		}
	}
}
