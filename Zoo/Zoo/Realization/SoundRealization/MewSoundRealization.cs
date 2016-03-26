using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Realization.SoundRealization
{
	public class MewSoundRealization : ISound
	{

		public void Sounding()
		{
			try
			{
				Console.WriteLine("Я мяукаю.");
			}
			catch (System.NullReferenceException)
			{
				Console.WriteLine("---");
			}
		}

		public string Sound
		{
			get{ return "мяукать"; }
			set { string sound = value; }
		}

	}
}
