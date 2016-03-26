using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Realization.SoundRealization
{
	class GiggleSoundRealization : ISound
	{

		public void Sounding()
		{
			try
			{
				Console.WriteLine("Я смеюсь.");
			}
			catch (System.NullReferenceException)
			{
				Console.WriteLine("---");
			}
		}

		public string Sound
		{
			get { return "смеяться"; }
			set { string sound = value; }
		}

	}
}
