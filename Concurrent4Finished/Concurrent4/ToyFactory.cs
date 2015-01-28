using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Concurrent4
{
    /// <summary>
    /// Class ToyFactory which is used by main form
    /// </summary>
    class ToyFactory
    {
        /// <summary>
        /// Create new toys with various names and propertys, an array of these toys and a buffer
        /// </summary>
        Toy Train = new Toy("Train", 3.00, 50.00);
        Toy TeddyBear = new Toy("Teddy Bear", 0.5, 100);
        Toy Football = new Toy("Football", 0.8, 30);
        Toy Basketball = new Toy("Basketball", 1.00, 30);
        Toy Book = new Toy("Book", 0.2, 10);
        Toy Ps4Game = new Toy("Half Life 3", 0.1, 10);
        Toy BoardGame = new Toy("Board Game", 2, 50);
        Toy Snowboard = new Toy("Snowboard", 5, 500);
        Toy Bicyle = new Toy("Mountain Bike", 20, 700);
        Toy RollerBlades = new Toy("RollarBlades", 10, 70);
        Toy TrainType2 = new Toy("Train_Type2", 3.00, 50.00);
        Toy TeddyBearType2 = new Toy("Teddy Bear_Type2", 0.5, 100);
        Toy FootballType2 = new Toy("Football_Type2", 0.8, 30);
        Toy BasketballType2 = new Toy("Basketball_Type2", 1.00, 30);
        Toy BookType2 = new Toy("Book_Type2", 0.2, 10);
        Toy Ps4GameType2 = new Toy("Half Life 3_Type2", 0.1, 10);
        Toy BoardGameType2 = new Toy("Board Game_Type2", 2, 50);
        Toy SnowboardType2 = new Toy("Snowboard_Type2", 5, 500);
        Toy BicyleType2 = new Toy("Mountain Bike_Type2", 20, 700);
        Toy RollerBladesType2 = new Toy("RollarBlades_Type2", 10, 70);
        Toy[] PossibleToy;
        Buffer b;

         /// <summary>
         /// Constructor which creates the array of possible toys to make and initilizes buffer b
         /// </summary>
         /// <param name="b"></param>
        public ToyFactory(Buffer b)
        {
            this.b = b;
            
            Toy[] PossibleToy = {Train, TeddyBear,Football, Basketball, Book, Ps4Game, BoardGame, Snowboard,
                                    Bicyle, RollerBlades, TrainType2, TeddyBearType2, FootballType2, BasketballType2,
                                    BookType2, Ps4GameType2, BoardGameType2, SnowboardType2, BicyleType2, RollerBladesType2};
            this.PossibleToy = PossibleToy;
        }

        /// <summary>
        /// Method to start the factory making toys, a for loop that keeps looping and calling the buffer method addtobuffer,
        /// </summary>
        public void startMakingToys()
        {
            for (int i = 0; i < 100;)
            {
                if(b.AddtoBuffer(makeAtoy()))
                {
                    i++;
                }

                Thread.Sleep(500);
            }
        }

        /// <summary>
        /// Method to return a random toy by accessing a random position in the possibletoy array
        /// </summary>
        /// <returns>a random toy</returns>
        private Toy makeAtoy()
        {
          Random r = new Random();
          return PossibleToy[r.Next(0, 19)];
        }
    }
}
