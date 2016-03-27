using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Realization.MoveRealization
{
	class SwimMoveRealization : IMovable
	{
		public void Move()
		{
			Console.Write("Я плаваю. ");
		}

		public string Moving
		{
			get { return "плавать"; }
			set { string move = value; }
		}


	}
}