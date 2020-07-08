using _99_MorningChallenge_DrofsnarClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _99_MorningChallenge_DrofsnarConsole
{
    class DrofsnarConsole
    {
        static void Main(string[] args)
        {
            GamePiece Bird = new GamePiece();
            Bird.PieceName = "Bird";
            Bird.PointValue = 10;

            GamePiece CrestedIbis = new GamePiece();
            Bird.PieceName = "CrestedIbis";
            CrestedIbis.PointValue = 100;

            GamePiece GreatKiskudee = new GamePiece();
            Bird.PieceName = "GreatKiskudee";
            GreatKiskudee.PointValue = 300;

            GamePiece RedCrossbill = new GamePiece();
            Bird.PieceName = "RedCrossbill";
            RedCrossbill.PointValue = 500;

            GamePiece RedNeckedPhalarope = new GamePiece();
            Bird.PieceName = "RedNeckedPhalarope";
            RedNeckedPhalarope.PointValue = 700;

            GamePiece EveningGrosbeak = new GamePiece();
            Bird.PieceName = "EveningGrosbeak";
            EveningGrosbeak.PointValue = 1000;

            GamePiece GreaterPrairieChicken = new GamePiece();
            Bird.PieceName = "GreaterPrairieChicken";
            GreaterPrairieChicken.PointValue = 2000;

            GamePiece IcelandGull = new GamePiece();
            Bird.PieceName = "IcelandGull";
            IcelandGull.PointValue = 3000;

            GamePiece OrangeBelliedParrot = new GamePiece();
            Bird.PieceName = "OrangeBelliedParrot";
            OrangeBelliedParrot.PointValue = 5000;

            GamePiece VulnerableBirdHunters = new GamePiece();
            Bird.PieceName = "VulnerableBirdHunters";
            VulnerableBirdHunters.PointValue = 200;


            // Read in the collisions from the text file
            string stringOfMoves = System.IO.File.ReadAllText(@"C:\ElevenFiftySD\GoldBadge\CSharpFundamentals\99_MorningChallenge_DrofsnarConsole\MoveList.txt");

            Console.WriteLine("Contents of WriteText.txt = {0}", stringOfMoves);

            Console.ReadKey();

            string[] collisions = stringOfMoves.Split(',');

            // Drofsnar's starting point
            int DrofsnarPoints = 5000;
            int DrofsnarLives = 3;

            //string drofsnarLives = "DrofsnarLives";

            //PropertyInfo prop = typeof(Customer).GetProperty(item.key);
            //if (prop == null)
            //    string value = (string)prop.GetValue(customer, EmptyArray);
            //template.SetTemplateAttribute(item.key, value);

            //string PieceName = collisions[12];


            //var PieceNameToVariable = PieceName.GetProperty;
            //var PieceNameToVariable = GetType(GamePiece).GetField(PieceName).GetValue() as GamePiece;

            //int Points = ${PieceName}.PointValue;
            int i = 0;
            int vulnerable = 0;
            while (DrofsnarLives > 0 && i < collisions.Length)
            {

                //foreach (var collision in collisions)
                switch (collisions[i])
                {
                    case "Bird":
                        DrofsnarPoints += 10;
                        Console.WriteLine($"Collision #{i+1}. {collisions[i]} Points: {DrofsnarPoints}. {DrofsnarLives} lives remaining.");
                        i += 1;
                        break;
                    case "CrestedIbis":
                        DrofsnarPoints += 100;
                        Console.WriteLine($"Collision #{i+1}. {collisions[i]} Points: {DrofsnarPoints}. {DrofsnarLives} lives remaining.");
                        i += 1;
                        break;
                    case "GreatKiskudee":
                        DrofsnarPoints += 100;
                        Console.WriteLine($"Collision #{i+1}. {collisions[i]} Points: {DrofsnarPoints}. {DrofsnarLives} lives remaining.");
                        i += 1;
                        break;
                    case "RedCrossbill":
                        DrofsnarPoints += 500;
                        Console.WriteLine($"Collision #{i+1}. {collisions[i]} Points: {DrofsnarPoints}. {DrofsnarLives} lives remaining.");
                        i += 1;
                        break;
                    case "RedNeckedPhalarope":
                        DrofsnarPoints += 700;
                        Console.WriteLine($"Collision #{i+1}. {collisions[i]} Points: {DrofsnarPoints}. {DrofsnarLives} lives remaining.");
                        i += 1;
                        break;
                    case "EveningGrosbeak":
                        DrofsnarPoints += 1000;
                        Console.WriteLine($"Collision #{i+1}. {collisions[i]} Points: {DrofsnarPoints}. {DrofsnarLives} lives remaining.");
                        i += 1;
                        break;
                    case "GreaterPrairieChicken":
                        DrofsnarPoints += 2000;
                        Console.WriteLine($"Collision #{i+1}. {collisions[i]} Points: {DrofsnarPoints}. {DrofsnarLives} lives remaining.");
                        i += 1;
                        break;
                    case "IcelandGull":
                        DrofsnarPoints += 3000;
                        Console.WriteLine($"Collision #{i+1}. {collisions[i]} Points: {DrofsnarPoints}. {DrofsnarLives} lives remaining.");
                        i += 1;
                        break;
                    case "OrangeBelliedParrot":
                        DrofsnarPoints += 5000;
                        Console.WriteLine($"Collision #{i+1}. {collisions[i]} Points: {DrofsnarPoints}. {DrofsnarLives} lives remaining.");
                        i += 1;
                        break;
                    case "VulnerableBirdHunter":
                        DrofsnarPoints += 2^vulnerable * 200;
                        vulnerable += 1;
                        Console.WriteLine($"Collision #{i+1}. {collisions[i]} Points: {DrofsnarPoints}. {DrofsnarLives} lives remaining.");
                        i += 1;
                        break;
                    case "InvincibleBirdHunter":
                        DrofsnarLives -= 1;
                        Console.WriteLine($"Collision #{i+1}. {collisions[i]} Points: {DrofsnarPoints}. {DrofsnarLives} lives remaining.");
                        i += 1;
                        break;
                    default:
                        Console.WriteLine($"Bad data at cell {i}");
                        Console.WriteLine($"Collision #{i+1}. {collisions[i]} Points: {DrofsnarPoints}. {DrofsnarLives} lives remaining.");
                        i += 1;
                        break;
                }
                }
            Console.WriteLine($"The last collision is at cell {i}");
            Console.WriteLine($"Drofsnar has {DrofsnarLives} lives");
            Console.WriteLine($"Drofsnar has {DrofsnarPoints} points");
                //Console.WriteLine($"{collision}");
            Console.ReadKey();

            }

        }


}

