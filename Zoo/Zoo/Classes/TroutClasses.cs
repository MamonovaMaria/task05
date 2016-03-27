using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Realization.MoveRealization;
using Zoo.Realization.SoundRealization;

namespace Zoo.Classes
{
	class TroutClasses : Animal
	{
		static List<IMovable> troutMove = new List<IMovable> { new  ImmobilityMoveRealization(), new SwimMoveRealization()};
		static List<ISound> troutSound = new List<ISound> { new  GurgleSoundRealization(), new SilentSoundRealization()};

		public TroutClasses(ISound s, IMovable m)
			: base()
		{
			name = "форель";
			sound = s;
			move = m;
		}

		public string GetName(TroutClasses t)
		{
			return "Я форель";
		}

		public void GetMove(TroutClasses t)
		{
			t.move.Move();
		}

		public void GetSound(TroutClasses t)
		{
			t.sound.Sounding();
		}

		public override void PrintMyName()
		{
			Console.Write("Я форель. ");
		}

		/// <summary>
		/// Осуществляет проверку на корректность поведения животного
		/// </summary>
		/// <param name="s"></param>
		/// <param name="m"></param>
		/// <returns></returns>
		static public bool TroutBirth(ISound s, IMovable m)
		{
			foreach (IMovable elM in troutMove)
			{
				if (m.Moving == elM.Moving)
				{
					foreach (ISound elS in troutSound)
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
