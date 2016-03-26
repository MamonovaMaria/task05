using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Realization.MoveRealization;
using Zoo.Realization.SoundRealization;

namespace Zoo.Classes
{
	class SparrowClasses : Animal
	{
		static List<IMovable> sparrowMove = new List<IMovable> { new  FlyMoveRealization(), new ImmobilityMoveRealization()};
		static List<ISound> sparrowSound = new List<ISound> { new SilentSoundRealization(), new TweetSoundRealization() };

		public SparrowClasses(ISound s, IMovable m)
			: base()
		{
			name = "воробей";
			sound = s;
			move = m;
		}

		public string GetName(SparrowClasses c)
		{
			return "Я воробей";
		}

		public void GetMove(SparrowClasses c)
		{
			c.move.Move();
		}

		public void GetSound(SparrowClasses c)
		{
			c.sound.Sounding();
		}

		public override void PrintMyName()
		{
			Console.Write("Я воробей. ");
		}

		/// <summary>
		/// Осуществляет проверку на корректность поведения животного
		/// </summary>
		/// <param name="s"></param>
		/// <param name="m"></param>
		/// <returns></returns>
		static public bool SparrowBirth(ISound s, IMovable m)
		{
			foreach (IMovable elM in sparrowMove)
			{
				if (m.Moving == elM.Moving)
				{
					foreach (ISound elS in sparrowSound)
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
