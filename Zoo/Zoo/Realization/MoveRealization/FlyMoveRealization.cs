using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Realization.MoveRealization
{
	class FlyMoveRealization : IMovable
	{
		public void Move()
		{
			Console.Write("Я летаю. ");
		}

		public string Moving
		{
			get { return "летать"; }
			set { string move = value; }
		}


	}
}