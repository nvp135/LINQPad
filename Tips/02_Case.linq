<Query Kind="Program">
  <Namespace>System.Runtime.Serialization</Namespace>
</Query>

void Main()
{
	var example = new Examples();
	example.ShowExample();
}

internal class Examples
	{
		public void ShowExample()
		{
			//SwitchOldSyntax();
			//SwitchOnType();
			//SwitchWithWhen();
		}

		private void SwitchOldSyntax()
		{
			// C# 7 added the Case pattern
			// now switch statement are not limited to core types
			// like integers and strings.
			int number = 23;
			//  old style
			switch (number)
			{
				case 0:

					break;
				case 10:
					break;
				case 20:
					break;
				case 21:
					break;
				case 22:
					break;
				case 23:
					Console.WriteLine("23 is the winning number!");
					break;
				case 24:
					break;
				case 30:
					break;
				default:
					break;
			}
		}

		public void SwitchOnType()
		{

			var cards = CardSource.GetCards();
			foreach (var card in cards)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.Write($"{card.Name} - \t");
				switch (card)
				{
					case Robot myRobot:
						Console.ForegroundColor = ConsoleColor.Yellow;
						Console.WriteLine($"This card is a robot card.");
						Console.WriteLine($"\t\tBattery level is {myRobot.BatteryLevel}");
						// include expression based on type

						if (myRobot.BatteryLevel < 50)
						{
							Console.ForegroundColor = ConsoleColor.Red;
							Console.WriteLine($"\t\tbattery low");
						}
						break;
					case Creature myCreature:
						Console.WriteLine($"This card is a creature card.");
						Console.WriteLine($"\t\teyecount: {myCreature.EyeCount}");
						break;
					case null:
						Console.WriteLine($"No card, null.");
						break;
					default:
						Console.ForegroundColor = ConsoleColor.Green;
						Console.WriteLine($" a standard trading card.");
						break;
				}
			}
		}

		private void SwitchWithWhen()
		{
			// case statements are not mutually exclusive anymore
			// use when to specify additional conditions
			var numbers = Enumerable.Range(1, 110);
			string message;
			var eighties = new List<int> { 80, 81, 82, 83, 84, 85, 86, 87, 88, 89 };
			foreach (var number in numbers)
			{
				message = string.Empty;
				switch (number)
				{
					case 42:
						message += "Meaning Of Life,";
						break;
					case var candidate when (candidate % 20 == 0):
						message += "Mod 20,";
						break;
					case var candidate when (eighties.Contains(candidate)):
						message += "Eighties,";
						break;
					default:
						break;
				}
				Console.WriteLine($"{number:D2}: {message}");
			}

		}
	}


public class Card
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public decimal ListPrice { get; set; }
		public decimal AskingPrice { get; set; }
		public decimal Discount { get { return AskingPrice * .45M; } }
		public decimal SalePrice { get { return AskingPrice - Discount; } }

		public string TypeName
		{
			get { return this.GetType().FullName; }
		}
	}
	public class Creature : Card
	{
		public int EyeCount { get; set; }
		public bool Spikes { get; set; }
		public bool Antenna { get; set; }
	}
	
	public class Monster : Creature {}


	public class Robot : Card , ISerializable
	{

		public decimal BatteryLevel { get; set; }
		public void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			throw new NotImplementedException();
		}
	}
	
	public class Cyborg : Robot { }
	public class Android : Robot { }
	
	public class CardSource
	{
		private static List<Card> _cards;
		static CardSource()
		{
			_cards = new List<Card>();

			_cards.Add(new Monster
			{
				Name = "Mingle",
				EyeCount = 2,
				ListPrice = 5.99M,
				AskingPrice = 15.95M,
				Description = "Mingle excels at doing twice the work in half the time, with pinpoint accuracy.  These skills serve her well in her role as Senior Data Analyst for an international cloud computing company. She's also got a penchant for ballroom dance, line dancing, and pretty much any kind of activity that lets her groove to music.",

				Spikes = false,
				Antenna = false,

			});
			_cards.Add(new Monster
			{
				Name = "Yodel",
				EyeCount = 2,
				ListPrice = 5.99M,
				AskingPrice = 6.95M,
				Description = "Yodel grew up in a family of singers and loud talkers and could never get a word in edgewise. Then his vast talent for yodeling emerged. Now he performs to adoring fans throughout the world, and always has the loudest voice at the dinner table. Incidentally, he's also a loud proponent of net neutrality, and spends countless hours moderating an Internet forum devoted solely to that subject.",

				Spikes = false,
				Antenna = true,

			});

			_cards.Add(new Monster
			{

				Name = "Squido",

				EyeCount = 2,
				ListPrice = 5.99M,
				AskingPrice = 6.95M,
				Description = "Squido's got his hands or rather tentacles, in everything. First and foremost, he's a web designer with an eye for visual aesthetics, but he's also rather keen on UX design and making sure what he creates translates optimally to the end user. In his off-hours he's an avid nature photographer and bowler.",

				Spikes = false,
				Antenna = false,


			});

			_cards.Add(new Monster
			{
				Name = "Spook",
				ListPrice = 5.99M,
				AskingPrice = 23.95M,
				Description = "Cracking code and battling hackers is Spook's forte. She holds a prominent position as Head of Cyber Security for the Department of Monster Defense, where she thwarts attacks on government computer systems as often as she blinks. When not at work, Spook delights in serving up a fright at haunted mansions and ghost walks.",
				Spikes = false,
				Antenna = false,
				EyeCount = 5
			});

			_cards.Add(new Cyborg
			{

				Name = "Blade",
				ListPrice = 5.99M,
				AskingPrice = 42.50M,

				Description = "Blade freelances as a mobile app developer and has built some of the most popular mobile apps used in modern cyborg society, including the award-winning Battery Watcher ",
				BatteryLevel = 37,
			});

			_cards.Add(new Android
			{
				Name = "Drift",
				ListPrice = 5.99M,
				AskingPrice = 17.95M,

				Description = "After years of everyone saying her head was in the clouds, Drift found her calling as a software engineer developing a well-known cloud solution for the computing giant, Red30 Tech. After work, she prefers to unwind by catching wind in her sail and paragliding high in the sky.",
				BatteryLevel = 96,
			});
			
		}
		public static List<Card> GetCards()
		{

			return _cards;

		}
	}