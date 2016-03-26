using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Realization.SoundRealization
{
	class GurgleSoundRealization : ISound
	{

		public void Sounding()
		{
			try
			{
				Console.WriteLine("Я булькаю.");
			}
			catch (System.NullReferenceException)
			{
				Console.WriteLine("---");
			}
		}

		public string Sound
		{
			get { return "булькать"; }
			set { string sound = value; }
		}

	}
}
