using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Realization.MoveRealization
{
	class ImmobilityMoveRealization : IMovable
	{
		public void Move()
		{
			Console.Write("Я не двигаюсь. ");
		}

		public string Moving
		{
			get { return "не двигаться"; }
			set { string move = value; }
		}


	}
}