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
	public class ZooCreator
	{
		Zoo zoo = new Zoo();

		/// <summary>
		/// Основное меню выбора
		/// </summary>
		public void Chioce()
		{
			Console.WriteLine("Какое действие осуществить?");
			Console.WriteLine("1.Добавить животное в зоопарк");
			Console.WriteLine("2.Опросить всех животных");
			Console.WriteLine("Esc.Выйти");
			Console.WriteLine();
		}

		/// <summary>
		/// Выбор вида животного
		/// </summary>
		public void ChoiceKinde()
		{
			Console.WriteLine("Какого вида новое животное?");
			Console.WriteLine("1.Кошка");
			Console.WriteLine("2.Змея");
			Console.WriteLine("3.Воробей");
			Console.WriteLine("4.Гиена");
			Console.WriteLine("5.Форель");
			Console.WriteLine();
		}

		/// <summary>
		/// Выбор типа движения
		/// </summary>
		public void ChoiceMove()
		{
			Console.WriteLine("Как оно будет двигаться?");
			Console.WriteLine("1.Лежать");
			Console.WriteLine("2.Бегать");
			Console.WriteLine("3.Быстро бегать");
			Console.WriteLine("4.Ползти");
			Console.WriteLine("5.Летать");
			Console.WriteLine("6.Плыть");
			Console.WriteLine("7.Не двигать");
			Console.WriteLine();

		}

		/// <summary>
		/// Выбор типа звуковоспроизведения
		/// </summary>
		public void ChoiceSound()
		{
			Console.WriteLine("Какие звуки оно будет издавать?");
			Console.WriteLine("1.Молчать");
			Console.WriteLine("2.Мяукать");
			Console.WriteLine("3.Шипеть");
			Console.WriteLine("4.Рычать");
			Console.WriteLine("5.Чирикать");
			Console.WriteLine("6.Злобно смеяться");
			Console.WriteLine("7.Булькать");
			Console.WriteLine();
		}

		public bool Menu()
		{
			Chioce();
			ConsoleKey keyK = Console.ReadKey(true).Key;

			switch (keyK)
			{
				case ConsoleKey.Escape: return false;
				case ConsoleKey.D1:
				case ConsoleKey.NumPad1:
					{
						Console.Clear();

						ChoiceKinde();
						ConsoleKey key = Console.ReadKey(true).Key;
						KindeCreator(key);

						Console.Clear();

						break;
					}
				case ConsoleKey.D2:
				case ConsoleKey.NumPad2: Interview(zoo); break;
			}
			return true;
		}

		/// <summary>
		/// Создание животного с добавлением его в зоопарк
		/// </summary>
		/// <param name="key"></param>
		public void KindeCreator(ConsoleKey key)
		{
			switch (key)
			{
				case ConsoleKey.D1:
				case ConsoleKey.NumPad1:
					{
						try
						{
							IMovable m = MoveCreator();
							ISound s = SoundCreator();
							CatClasses c = new CatClasses(s, m);
							try
							{
								if (CatClasses.CatBirth(s, m))
									zoo.animal.Add(new CatClasses(s, m));
							}
							catch (ArgumentException exc)
							{
								ExceptionHandling(exc);
							}
						}
						catch (ArgumentException ex)
						{
							Console.WriteLine(ex.Message);
						}
						return;
					}
				case ConsoleKey.D2:
				case ConsoleKey.NumPad2:
					{
						IMovable m = MoveCreator();
						ISound s = SoundCreator();
						SnakeClasses c = new SnakeClasses(s, m);
						try
						{
							if (SnakeClasses.SnakeBirth(s, m))
								zoo.animal.Add(new SnakeClasses(s, m));
						}
						catch (ArgumentException exc)
						{
							ExceptionHandling(exc);
						}
						return;
					}
				case ConsoleKey.D3:
				case ConsoleKey.NumPad3:
					{
						IMovable m = MoveCreator();
						ISound s = SoundCreator();
						SparrowClasses c = new SparrowClasses(s, m);
						try
						{
							if (SparrowClasses.SparrowBirth(s, m))
								zoo.animal.Add(new SparrowClasses(s, m));
						}
						catch (ArgumentException exc)
						{
							ExceptionHandling(exc);
						}
						return;
					}
				case ConsoleKey.D4:
				case ConsoleKey.NumPad4:
					{
						IMovable m = MoveCreator();
						ISound s = SoundCreator();
						HyenaClasses c = new HyenaClasses(s, m);
						try
						{
							if (HyenaClasses.HyenaBirth(s, m))
								zoo.animal.Add(new HyenaClasses(s, m));
						}
						catch (ArgumentException exc)
						{
							ExceptionHandling(exc);
						}
						return;
					}
				case ConsoleKey.D5:
				case ConsoleKey.NumPad5:
					{
						IMovable m = MoveCreator();
						ISound s = SoundCreator();
						TroutClasses c = new TroutClasses(s, m);
						try
						{
							if (TroutClasses.TroutBirth(s, m))
								zoo.animal.Add(new TroutClasses(s, m));
						}
						catch (ArgumentException exc)
						{
							ExceptionHandling(exc);
						}
						return;
					}
				default: throw new ArgumentException("несуществующий пункт меню");
			}
		}

		/// <summary>
		/// Определение типа действий животного
		/// </summary>
		/// <returns></returns>
		public IMovable MoveCreator()
		{
			ChoiceMove();
			ConsoleKey key = Console.ReadKey(true).Key;
			switch (key)
			{
				case ConsoleKey.D1:
				case ConsoleKey.NumPad1:
					{
						return new LieMoveRealization();
					}
				case ConsoleKey.D2:
				case ConsoleKey.NumPad2:
					{
						return new RunMoveRealization();
					}
				case ConsoleKey.D3:
				case ConsoleKey.NumPad3:
					{
						return new RunFastMoveRealization();
					}

				case ConsoleKey.D4:
				case ConsoleKey.NumPad4:
					{
						return new SlitherMoveRealization();
					}

				case ConsoleKey.D5:
				case ConsoleKey.NumPad5:
					{
						return new FlyMoveRealization();
					}

				case ConsoleKey.D6:
				case ConsoleKey.NumPad6:
					{
						return new SwimMoveRealization();
					}

				case ConsoleKey.D7:
				case ConsoleKey.NumPad7:
					{
						return new ImmobilityMoveRealization();
					}
				default: throw new ArgumentException("несуществующий пункт меню");
			}
		}

		/// <summary>
		/// Определение типа звуков животного
		/// </summary>
		/// <returns></returns>
		public ISound SoundCreator()
		{
			ChoiceSound();
			ConsoleKey key = Console.ReadKey(true).Key;
			switch (key)
			{
				case ConsoleKey.D1:
				case ConsoleKey.NumPad1:
					{
						return new SilentSoundRealization();
					}
				case ConsoleKey.D2:
				case ConsoleKey.NumPad2:
					{
						return new MewSoundRealization();
					}
				case ConsoleKey.D3:
				case ConsoleKey.NumPad3:
					{
						return new SizzleSoundRealization();
					}
				case ConsoleKey.D4:
				case ConsoleKey.NumPad4:
					{
						return new GrowlSoundRealization();
					}
				case ConsoleKey.D5:
				case ConsoleKey.NumPad5:
					{
						return new TweetSoundRealization();
					}
				case ConsoleKey.D6:
				case ConsoleKey.NumPad6:
					{
						return new GiggleSoundRealization();
					}
				case ConsoleKey.D7:
				case ConsoleKey.NumPad7:
					{
						return new GurgleSoundRealization();
					}
				default: throw new ArgumentException("несуществующий пункт меню");
			}

		}

		/// <summary>
		/// Обработка некорректного задания поведения животного
		/// </summary>
		/// <param name="exc"></param>
		public void ExceptionHandling(ArgumentException exc)
		{
			Console.Clear();

			Console.WriteLine("Животное странное. \n");
			switch (exc.Message)
			{
				case "некорректный звук": Console.WriteLine("Подробнее: некорректный звук животного\n"); break;
				case "некорректное действие": Console.WriteLine("Подробнее: некорректное действие животного\n"); break;
			}
			Console.WriteLine("Мы не можем принять его в наш зоопарк. \nПопробуйте ещё раз.\n");

		}

		/// <summary>
		/// Опрос всех животных в зоопарке
		/// </summary>
		/// <param name="zoo"></param>
		public void Interview(Zoo zoo)
		{
			Console.Clear();

			zoo.PrintAnimalsList();
			Console.WriteLine("\n");
		}
	}
}
