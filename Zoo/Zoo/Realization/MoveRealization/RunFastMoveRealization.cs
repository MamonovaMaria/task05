using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Realization.MoveRealization
{
	class RunFastMoveRealization : IMovable
	{
		public void Move()
		{
			Console.Write("Я быстро бегаю. ");
		}

		public string Moving
		{
			get { return "быстро бегать"; }
			set { string move = value; }
		}


	}
}