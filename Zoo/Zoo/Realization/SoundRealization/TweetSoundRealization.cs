using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Realization.SoundRealization
{
	class TweetSoundRealization : ISound
	{

		public void Sounding()
		{
			try
			{
				Console.WriteLine("Я чирикаю.");
			}
			catch (System.NullReferenceException)
			{
				Console.WriteLine("---");
			}
		}

		public string Sound
		{
			get { return "чирикать"; }
			set { string sound = value; }
		}

	}
}
