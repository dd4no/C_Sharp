using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using Casino;
using Casino.Blackjack;

namespace Blackjack
{
    class Program
    {
        static void Main()
        {
            // Welcome message
            Console.WriteLine("LET'S PLAY BLACKJACK!\n");

            // Get player name
            Console.WriteLine("Please Enter Your Name:");
            string playerName = Console.ReadLine();
            if (playerName.ToLower() == "admin")
            {
                List<ExceptionEntity> Exceptions = ReadExceptions();
                foreach (var exception in Exceptions)
                {
                    Console.Write(exception.Id + " | ");
                    Console.Write(exception.ExceptionType + " | ");
                    Console.Write(exception.ExceptionMessage + " | ");
                    Console.Write(exception.TimeStamp + " | ");
                    Console.WriteLine();
                }
                Console.Read();
                return;
            }

            // Get player starting amount
            bool validAnswer = false;
            int purse = 0;
            while (!validAnswer)
            {
                Console.WriteLine("\nHow much money are you starting with?");
                Console.Write("$");
                validAnswer = int.TryParse(Console.ReadLine(), out purse);
                if (!validAnswer)
                {
                    Console.WriteLine("Please enter a whole number");
                }
            }

            // Ask to start game
            Console.WriteLine("\nHello, {0}! \nReady to get started? (y or n)", playerName);
            string ready = Console.ReadLine().ToLower();
            
            // Initialize game if player is ready
            if (ready == "yes" || ready == "y")
            {
                // Create new player object
                Player player = new Player(playerName, purse);
                player.ID = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\daved\Desktop\log.txt", true))
                {
                    file.WriteLine(player.ID);
                }

                //Create new game object 
                Game game = new BlackjackGame();
                // Add player to list of game players
                game += player;
                // Set player's playing status to "Active"
                player.IsActive = true;
                // Skip a line for presentation
                Console.WriteLine();
                // Start game loop and continue until player quits or runs out of money
                while (player.IsActive && player.Balance > 0)
                {
                    try
                    {
                        game.Play();
                    }
                    catch (FraudException ex)
                    {
                        Console.WriteLine(ex.Message);
                        UpdateDbWithException(ex);
                        return;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Something went wrong.");
                        UpdateDbWithException(ex);
                        return;
                    }
                }
                // Remove player from list of game players when done
                game -= player;
                // Ending message
                Console.WriteLine("Thanks for playing!");
            }
            // Goodbye message and end of program
            Console.WriteLine("Please come back when you are ready to play.");
            Console.Read();
        }

        private static void UpdateDbWithException(Exception ex)
        {
            string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = BlackjackGame;
                                        Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
                                        TrustServerCertificate = False; ApplicationIntent = ReadWrite; 
                                        MultiSubnetFailover = False";
            string queryString = @"INSERT INTO Exceptions (ExceptionType, ExceptionMessage, TimeStamp)
                                    VALUES (@ExceptionType, @ExceptionMessage, @TimeStamp)";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                command.Parameters.Add("@ExceptionType", SqlDbType.VarChar);
                command.Parameters.Add("@ExceptionMessage", SqlDbType.VarChar);
                command.Parameters.Add("@TimeStamp", SqlDbType.DateTime);

                command.Parameters["@ExceptionType"].Value = ex.GetType().ToString();
                command.Parameters["@ExceptionMessage"].Value = ex.Message;
                command.Parameters["@TimeStamp"].Value = DateTime.Now;

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }

        private static List<ExceptionEntity> ReadExceptions()
        {
            string connectionString = @"Data Source = (localdb)\ProjectsV13; Initial Catalog = BlackjackGame;
                                        Integrated Security = True; Connect Timeout = 30; Encrypt = False; 
                                        TrustServerCertificate = False; ApplicationIntent = ReadWrite; 
                                        MultiSubnetFailover = False";

            string queryString = @"SELECT Id, ExceptionType, ExceptionMessage, TimeStamp FROM Exceptions";

            List<ExceptionEntity> Exceptions = new List<ExceptionEntity>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ExceptionEntity exception = new ExceptionEntity();
                    exception.Id = Convert.ToInt32(reader["Id"]);
                    exception.ExceptionType = reader["ExceptionType"].ToString();
                    exception.ExceptionMessage = reader["ExceptionMessage"].ToString();
                    exception.TimeStamp = Convert.ToDateTime(reader["TimeStamp"]);
                    Exceptions.Add(exception);
                }
                connection.Close();
            }
            return Exceptions;

        }
    }
}
