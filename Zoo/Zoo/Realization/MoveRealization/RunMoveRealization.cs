using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Realization.MoveRealization
{
	public class RunMoveRealization : IMovable
	{
		public void Move()
		{
				Console.Write("Я бегаю. ");
		}

		public string Moving
		{
			get { return "бегать"; }
			set { string move = value; }
		}


	}
}
