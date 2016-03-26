using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Realization.SoundRealization
{
	class GrowlSoundRealization : ISound
	{

		public void Sounding()
		{
			try
			{
				Console.WriteLine("Я рычу.");
			}
			catch (System.NullReferenceException)
			{
				Console.WriteLine("---");
			}
		}

		public string Sound
		{
			get { return "рычать"; }
			set { string sound = value; }
		}

	}
}
