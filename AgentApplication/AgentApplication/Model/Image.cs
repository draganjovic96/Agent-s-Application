using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgentApplication.Model
{
	public class Image
	{
		[Key]
		public long Id { get; set; }

		public string Name { get; set; }

		public byte Img { get; set; }

		public Accommodation Accommodation { get; set; }
	}
}
