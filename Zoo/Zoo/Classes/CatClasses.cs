using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Realization.MoveRealization;
using Zoo.Realization.SoundRealization;

namespace Zoo.Classes
{
	public class CatClasses : Animal
	{
		static List<IMovable> catMove = new List<IMovable> { new RunMoveRealization(), new ImmobilityMoveRealization(), new RunFastMoveRealization(), new LieMoveRealization() };
		static List<ISound> catSound = new List<ISound> { new MewSoundRealization(), new GrowlSoundRealization(), new SilentSoundRealization() };

		public CatClasses(ISound s, IMovable m)
			: base()
		{
			name = "кошка";
			sound = s;
			move = m;
		}

		public string GetName(CatClasses c)
		{
			return "Я кошка";
		}

		public void GetMove(CatClasses c)
		{
			c.move.Move();
		}

		public void GetSound(CatClasses c)
		{
			c.sound.Sounding();
		}

		public override void PrintMyName()
		{
			Console.Write("Я кошка. ");
		}

		/// <summary>
		/// Осуществляет проверку на корректность поведения животного
		/// </summary>
		/// <param name="s"></param>
		/// <param name="m"></param>
		/// <returns></returns>
		static public bool CatBirth(ISound s, IMovable m)
		{
			foreach (IMovable elM in catMove)
			{
				if (m.Moving == elM.Moving)
				{
					foreach (ISound elS in catSound)
					{
						if (s.Sound == elS.Sound)
						{
							return true;
						}
					}
					throw new ArgumentException("некорректный звук");
				}
			}
			throw new ArgumentException("некорректное действие");
		}
	}
}
