using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Realization.MoveRealization
{
	public class SlitherMoveRealization : IMovable
	{

		public void Move()
		{
			Console.Write("Я ползаю. ");
		}

		public string Moving
		{
			get { return "ползать"; }
			set { string move = value; }
		}

	}
}
