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
	public class Zoo
	{
		public List<Animal> animal = new List<Animal>();
		protected List<IMovable> move = new List<IMovable> { new RunMoveRealization(), new SlitherMoveRealization(), new FlyMoveRealization(), new ImmobilityMoveRealization(), new LieMoveRealization(), new RunFastMoveRealization(), new SwimMoveRealization()};
		protected List<ISound> sound = new List<ISound> { new MewSoundRealization(), new SizzleSoundRealization(), new GurgleSoundRealization(), new GiggleSoundRealization(), new GrowlSoundRealization(), new SilentSoundRealization(), new TweetSoundRealization() };

		public void PrintAnimalsList()
		{
			foreach (Animal a in animal)
			{
				a.PrintMyName();
				a.PrintMyMove();
				a.PrintMySound();
			}
		}
	}
}
//AnimalBirth