using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentApplication.Model
{
	class CommentRate
	{
		private long Id { get; set; }

		private bool ApprovedComment { get; set; }

		private string ContentOfComment { get; set; }

		private DateTime CommentDateTime { get; set; }

		private int Ocena { get; set; }
	}
}
