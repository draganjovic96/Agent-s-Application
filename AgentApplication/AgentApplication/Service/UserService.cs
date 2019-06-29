using AgentApplication.Model;
using AgentApplication.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AgentApplication.Service
{
	public class UserService
	{
		private MojuserPortClient mojUserClient = new MojuserPortClient();

		public User LoginUser(string username, string password) {

			LoginDTO loginUser = new LoginDTO
			{
				username = username,
				password = password,
				role = UserRole.AGENT.ToString()
			};

			loginRequest loginRequest = new loginRequest
			{
				loginDTO = loginUser
			};

			try
			{
				loginResponse loginResponse = mojUserClient.login(loginRequest);
				return new User(loginResponse.user);
			}
			catch (System.ServiceModel.FaultException ex)
			{
				return null;
			}

		}
	}
}
