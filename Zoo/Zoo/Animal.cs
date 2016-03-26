using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
	public abstract class Animal
	{
		protected ISound sound;
		protected IMovable move;
		protected string name = "----";

		public Animal() { ;}

		public ISound MySound
		{
			get
			{
				return sound;
			}
			set
			{
				sound = value;
			}
		}

		public IMovable MyMove
		{
			get
			{
				return move;
			}
			set
			{
				move = value;
			}
		}

		public string MyName
		{
			get
			{
				return name;
			}
			set
			{
				name = value;
			}
		}


		public void PrintMySound()
		{
			try
			{
				sound.Sounding();
			}
			catch (System.NullReferenceException)
			{
				Console.Write("---");
			}
		}

		public void PrintMyMove()
		{
			try
			{
				move.Move();
			}
			catch (System.NullReferenceException)
			{
				Console.Write("---");
			}

		}

		public abstract void PrintMyName();
	}
}
