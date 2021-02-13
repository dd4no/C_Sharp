using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.Blackjack
{
    public class BlackjackGame : Game, IWalkAway
    {
        public BlackjackDealer Dealer { get; set; }

        public override void Play()
        {
            Dealer = new BlackjackDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;
            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle();

            foreach (Player player in Players)
            {
                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("{0}, please place your bet:", player.Name);
                    Console.Write("$");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer)
                    {
                        Console.WriteLine("Please enter a whole number.");
                    }
                }
                if (bet < 0)
                {
                    throw new FraudException("Suspicious activity detected. Security has been notified.");
                }

                bool HasFunds = player.Bet(bet);
                if (!HasFunds)
                {
                    return;
                }
                Bets[player] = bet;
                Console.WriteLine();
                Console.WriteLine("Dealing cards...\n");

            }

            for (int i = 0; i < 2; i++)
            {
                foreach (Player player in Players)
                {
                    Console.Write("{0} gets: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = BlackjackRules.IsBlackjack(player.Hand);
                        if (blackJack)
                        {
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, Bets[player]);
                            player.Balance += Convert.ToInt32((Bets[player] * 1.5) + Bets[player]);
                            return;
                        }
                    }
                }
                Console.Write("Dealer gets: ");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = BlackjackRules.IsBlackjack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has Blackjack!  Everyone loses.");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        return;
                    }
                }
            }

            foreach (Player player in Players)
            {
                while (!player.Stay)
                {
                    Console.WriteLine("{0}'s cards: ", player.Name);
                    foreach (Card card in player.Hand)
                    {
                        Console.WriteLine("{0}", card.ToString());
                    }
                    Console.WriteLine("\n\nHit or Stay? (h or s)");
                    string decision = Console.ReadLine().ToLower();
                    if (decision == "stay" || decision == "s")
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (decision == "hit" || decision == "h")
                    {
                        Console.WriteLine("Your new card:");
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = BlackjackRules.HasBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        player.Balance -= Bets[player];
                        Console.WriteLine("You busted!  You lose your bet of ${0}. You have ${1} remaining.", Bets[player], player.Balance);
                        Console.WriteLine("\nWould you like to play again? (y or n)");
                        decision = Console.ReadLine().ToLower();
                        if (decision == "yes" || decision == "y")
                        {
                            player.IsActive = true;
                        }
                        else
                        {
                            player.IsActive = false;
                        }
                    }
                }
            }

            Dealer.HasBusted = BlackjackRules.HasBusted(Dealer.Hand);
            Dealer.Stay = BlackjackRules.DealerHitOrStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.HasBusted)
            {
                Console.WriteLine("Dealer hits.");
                Dealer.Deal(Dealer.Hand);
                Dealer.HasBusted = BlackjackRules.HasBusted(Dealer.Hand);
                Dealer.Stay = BlackjackRules.DealerHitOrStay(Dealer.Hand);
            }

            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer stays.");
            }
            if (Dealer.HasBusted)
            {
                Console.WriteLine("Dealer has busted!  Everyone wins!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                    Console.WriteLine("{0} won ${1}.", entry.Key.Name, entry.Value);
                }
                return;
            }
            foreach (Player player in Players)
            {
                bool? playerWins = BlackjackRules.CompareHands(player.Hand, Dealer.Hand);
                if (playerWins == null)
                {
                    Console.WriteLine("Push.  No one wins.");
                    player.Balance += Bets[player];
                }
                else if (playerWins == true)
                {
                    Console.WriteLine("{0} won ${1}!", player.Name, Bets[player]);
                }
                else
                {
                    Console.WriteLine("Dealer wins.");
                    Dealer.Balance += Bets[player];
                }
                Console.WriteLine("Play Again? (y or n)");
                string again = Console.ReadLine().ToLower();
                if (again == "yes" || again == "y")
                {
                    player.IsActive = true;
                    return;
                }
                else
                {
                    player.IsActive = false;
                    return;
                }
            }
        }

        public override void ListPlayers()
        {
            Console.WriteLine("Blackjack Players: ");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
