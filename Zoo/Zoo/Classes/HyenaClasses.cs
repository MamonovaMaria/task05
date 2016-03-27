using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Realization.MoveRealization;
using Zoo.Realization.SoundRealization;

namespace Zoo.Classes
{
	class HyenaClasses : Animal
	{
		static List<IMovable> hyenaMove = new List<IMovable> { new RunMoveRealization(), new  ImmobilityMoveRealization(), new LieMoveRealization(), new RunFastMoveRealization()};
		static List<ISound> hyenaSound = new List<ISound> { new GiggleSoundRealization(), new GrowlSoundRealization(), new SilentSoundRealization()};

		public HyenaClasses(ISound s, IMovable m)
			: base()
		{
			name = "гиена";
			sound = s;
			move = m;
		}

		public string GetName(HyenaClasses c)
		{
			return "Я гиена";
		}

		public void GetMove(HyenaClasses c)
		{
			c.move.Move();
		}

		public void GetSound(HyenaClasses c)
		{
			c.sound.Sounding();
		}

		public override void PrintMyName()
		{
			Console.Write("Я гиена. ");
		}

		/// <summary>
		/// Осуществляет проверку на корректность поведения животного
		/// </summary>
		/// <param name="s"></param>
		/// <param name="m"></param>
		/// <returns></returns>
		static public bool HyenaBirth(ISound s, IMovable m)
		{
			foreach (IMovable elM in hyenaMove)
			{
				if (m.Moving == elM.Moving)
				{
					foreach (ISound elS in hyenaSound)
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
