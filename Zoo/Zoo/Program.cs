using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Classes;
using Zoo.Realization.MoveRealization;
using Zoo.Realization.SoundRealization;


namespace Zoo
{
	class Program
	{
		static void Main(string[] args)
		{
			Log tester = new Log();
			tester.lg("test");

			ZooCreator creat = new ZooCreator();

			while (creat.Menu())
			{ }
			return;
		}
	}


	public class Log
	{
		private readonly Logger logger;

		public Log()
		{
			logger = LogManager.GetCurrentClassLogger();
		}

		public void lg(string massage)
		{
			logger.Info(massage);
		}
	}

}
