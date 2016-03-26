using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Realization.MoveRealization;
using Zoo.Realization.SoundRealization;

namespace Zoo.Classes
{
	class SnakeClasses : Animal
	{
		static List<IMovable> snakeMove = new List<IMovable> { new ImmobilityMoveRealization(), new SlitherMoveRealization()};
		static List<ISound> snakeSound = new List<ISound> { new SilentSoundRealization(), new SizzleSoundRealization()};

		public SnakeClasses(ISound s, IMovable m)
			: base()
		{
			name = "змея";
			sound = s;
			move = m;
		}

		public string GetName(SnakeClasses c)
		{
			return "Я змея";
		}

		public void GetMove(SnakeClasses c)
		{
			c.move.Move();
		}

		public void GetSound(SnakeClasses c)
		{
			c.sound.Sounding();
		}

		public override void PrintMyName()
		{
			Console.Write("Я змея. ");
		}

		/// <summary>
		/// Осуществляет проверку на корректность поведения животного
		/// </summary>
		/// <param name="s"></param>
		/// <param name="m"></param>
		/// <returns></returns>
		static public bool SnakeBirth(ISound s, IMovable m)
		{
			foreach (IMovable elM in snakeMove)
			{
				if (m.Moving == elM.Moving)
				{
					foreach (ISound elS in snakeSound)
					{
						if (s.Sound == elS.Sound)
							return true;
					}
					throw new ArgumentException("некорректный звук");
				}
			}
			throw new ArgumentException("некорректное действие");
		}
	}
}
