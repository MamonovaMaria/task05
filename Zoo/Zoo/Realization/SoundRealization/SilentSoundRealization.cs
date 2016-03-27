using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Realization.SoundRealization
{
	class SilentSoundRealization : ISound
	{

		public void Sounding()
		{
			try
			{
				Console.WriteLine("Я молчу (это интервью не в счет).");
			}
			catch (System.NullReferenceException)
			{
				Console.WriteLine("---");
			}
		}

		public string Sound
		{
			get { return "молчать"; }
			set { string sound = value; }
		}

	}
}
