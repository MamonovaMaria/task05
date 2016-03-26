using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Realization.SoundRealization
{
	public class SizzleSoundRealization : ISound
	{

		public void Sounding()
		{
			Console.WriteLine("Я издаю шипение");
		}

		public string Sound
		{
			get { return "шипеть"; }
			set { string sound = value; }
		}

	}
}
