using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Realization.MoveRealization
{
	class LieMoveRealization : IMovable
	{
		public void Move()
		{
			Console.Write("Я лежу. ");
		}

		public string Moving
		{
			get { return "лежать"; }
			set { string move = value; }
		}


	}
}