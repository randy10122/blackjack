using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace blackjack
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> cards = new Dictionary<string, int>(); // card dictionary works
            cards.Add("Ace of Clubs", 1); // aces are gonna be a problem i think
            cards.Add("Two of Clubs", 2); // aces are not a problem actually
            cards.Add("Three of Clubs", 3);
            cards.Add("Four of Clubs", 4);
            cards.Add("Five of Clubs", 5);
            cards.Add("Six of Clubs", 6);
            cards.Add("Seven of Clubs", 7);
            cards.Add("Eight of Clubs", 8);
            cards.Add("Nine of Clubs", 9);
            cards.Add("Ten of Clubs", 10);
            cards.Add("Jack of Clubs", 10);
            cards.Add("Queen of Clubs", 10);
            cards.Add("King of Clubs", 10);

            cards.Add("Ace of Spades", 1); // im not entirely sure if there is an effective way to edit a dictionary within the program
            cards.Add("Two of Spades", 2); // found out a way to edit dictionary values so she'll be right
            cards.Add("Three of Spades", 3);
            cards.Add("Four of Spades", 4);
            cards.Add("Five of Spades", 5);
            cards.Add("Six of Spades", 6);
            cards.Add("Seven of Spades", 7);
            cards.Add("Eight of Spades", 8);
            cards.Add("Nine of Spades", 9);
            cards.Add("Ten of Spades", 10);
            cards.Add("Jack of Spades", 10);
            cards.Add("Queen of Spades", 10);
            cards.Add("King of Spades", 10);

            cards.Add("Ace of Diamonds", 1);
            cards.Add("Two of Diamonds", 2);
            cards.Add("Three of Diamonds", 3);
            cards.Add("Four of Diamonds", 4);
            cards.Add("Five of Diamonds", 5);
            cards.Add("Six of Diamonds", 6);
            cards.Add("Seven of Diamonds", 7);
            cards.Add("Eight of Diamonds", 8);
            cards.Add("Nine of Diamonds", 9);
            cards.Add("Ten of Diamonds", 10);
            cards.Add("Jack of Diamonds", 10);
            cards.Add("Queen of Diamonds", 10);
            cards.Add("King of Diamonds", 10);

            cards.Add("Ace of Hearts", 1);
            cards.Add("Two of Hearts", 2);
            cards.Add("Three of Hearts", 3);
            cards.Add("Four of Hearts", 4);
            cards.Add("Five of Hearts", 5);
            cards.Add("Six of Hearts", 6);
            cards.Add("Seven of Hearts", 7);
            cards.Add("Eight of Hearts", 8);
            cards.Add("Nine of Hearts", 9);
            cards.Add("Ten of Hearts", 10);
            cards.Add("Jack of Hearts", 10);
            cards.Add("Queen of Hearts", 10);
            cards.Add("King of Hearts", 10);


            int money = 500;
            bool hitorFold;
            bool folding = false;
            bool debugmode = false;

            Console.WriteLine("Welcome to Randy's Wacky Blackjacky!");
            Thread.Sleep(250);

            while (true)
            {

                if (money <= 0)
                {
                    Console.WriteLine("You have $" + money + ", which means you are bankrupt. You lose.");
                    break;
                }
                bool folded = false;
                bool playing = false;
                if (playing == false) // this is the solution i figured out for resetting the deck
                {                    // its not pretty but it works 
                    cards.Clear();  // i hate dictionaries i hate dictionaries

                    cards.Add("Ace of Clubs", 1); cards.Add("Two of Clubs", 2); cards.Add("Three of Clubs", 3); cards.Add("Four of Clubs", 4); cards.Add("Five of Clubs", 5); cards.Add("Six of Clubs", 6); cards.Add("Seven of Clubs", 7); cards.Add("Eight of Clubs", 8); cards.Add("Nine of Clubs", 9); cards.Add("Ten of Clubs", 10); cards.Add("Jack of Clubs", 10); cards.Add("Queen of Clubs", 10); cards.Add("King of Clubs", 10);
                    cards.Add("Ace of Spades", 1); cards.Add("Two of Spades", 2); cards.Add("Three of Spades", 3); cards.Add("Four of Spades", 4); cards.Add("Five of Spades", 5); cards.Add("Six of Spades", 6); cards.Add("Seven of Spades", 7); cards.Add("Eight of Spades", 8); cards.Add("Nine of Spades", 9); cards.Add("Ten of Spades", 10); cards.Add("Jack of Spades", 10); cards.Add("Queen of Spades", 10); cards.Add("King of Spades", 10);
                    cards.Add("Ace of Diamonds", 1); cards.Add("Two of Diamonds", 2); cards.Add("Three of Diamonds", 3); cards.Add("Four of Diamonds", 4); cards.Add("Five of Diamonds", 5); cards.Add("Six of Diamonds", 6); cards.Add("Seven of Diamonds", 7); cards.Add("Eight of Diamonds", 8); cards.Add("Nine of Diamonds", 9); cards.Add("Ten of Diamonds", 10); cards.Add("Jack of Diamonds", 10); cards.Add("Queen of Diamonds", 10); cards.Add("King of Diamonds", 10);
                    cards.Add("Ace of Hearts", 1); cards.Add("Two of Hearts", 2); cards.Add("Three of Hearts", 3); cards.Add("Four of Hearts", 4); cards.Add("Five of Hearts", 5); cards.Add("Six of Hearts", 6); cards.Add("Seven of Hearts", 7); cards.Add("Eight of Hearts", 8); cards.Add("Nine of Hearts", 9); cards.Add("Ten of Hearts", 10); cards.Add("Jack of Hearts", 10); cards.Add("Queen of Hearts", 10); cards.Add("King of Hearts", 10);
                }
                Thread.Sleep(250);
                Console.WriteLine("You have $" + money + ". Please input a bet.");
                var betInput = Console.ReadLine();
                if (betInput == "THAW")
                {
                    Thread.Sleep(300);
                    Console.WriteLine("Debug mode enabled.");
                    debugmode = true;
                    Thread.Sleep(200);
                    continue;
                }
                if (betInput == "THAW" && debugmode == true)
                {
                    Thread.Sleep(300);
                    Console.WriteLine("Debug mode disabled.");
                    debugmode = false;
                    Thread.Sleep(200);
                    continue;
                }
                bool betisNumber = int.TryParse(betInput, out _); // but now, if you input a number, it doesn't work 
                if (betisNumber == false)
                {
                    Thread.Sleep(100);
                    Console.WriteLine("Not a valid number. Please input a reasonable bet.");
                    continue;
                }
                int amountBet = (int)Int64.Parse(betInput); // if you enter a non-number, this works
                Thread.Sleep(100);
                Console.WriteLine("You bet $" + amountBet + "."); 

                if (amountBet > money)
                {
                    Thread.Sleep(200);
                    Console.WriteLine("You do not have that much money. Please input a reasonable bet.");
                    continue;
                }
                if (amountBet <= 0)
                {
                    Thread.Sleep(100);
                    Console.WriteLine("You can't bet less than one dollar. Please input a reasonable bet.");
                    continue;
                }
                money -= amountBet;

                Random rnd2 = new Random();
                int dcard = rnd2.Next(0, cards.Count);
                int dcardValue = cards.ElementAt(dcard).Value; string dcardName = cards.ElementAt(dcard).Key;
                cards.Remove(dcardName, out dcardValue);

                Random rnd3 = new Random();
                int dcard2 = rnd3.Next(0, cards.Count);
                int dcardValue2 = cards.ElementAt(dcard2).Value; string dcardName2 = cards.ElementAt(dcard2).Key;
                cards.Remove(dcardName2, out dcardValue2);

                int dHandWorth = dcardValue + dcardValue2;
                playing = true;

                int handWorth = 0;
                while (playing == true)
                {
                    Thread.Sleep(200);
                    Console.WriteLine("The dealer has a " + dcardName + ", worth " + dcardValue + ", and a hidden card.");
                    if (debugmode == true)
                    {
                        Console.WriteLine("[DEBUG: hidden = " + dcardName2 + " worth " + dcardValue2 + ", hand worth = " + dHandWorth + "]" ); // DEBUG LINE
                    }
                    Random rnd = new Random();
                    int card = rnd.Next(0, cards.Count);
                    int cardValue = cards.ElementAt(card).Value; string cardName = cards.ElementAt(card).Key;
                    cards.Remove(cardName, out cardValue);
                    int cardamount = cards.Count; // this needs to be here or it doesnt recount properly
                                                  // this silly looking solution for aces actually works its kind of funny
                                                  // absolutely wild even
                    if (cardName == "Ace of Hearts" || cardName == "Ace of Clubs" || cardName == "Ace of Diamonds" || cardName == "Ace of Spades")
                    {
                        if (handWorth <= 10 || dHandWorth <= 10)
                        {
                            cardValue = 11;
                        }
                        if (handWorth > 10)
                        {
                            cardValue = 1;
                        }
                    }
                    Thread.Sleep(250);
                    Console.WriteLine("You drew a " + cardName + " worth " + cardValue);
                    hitorFold = false;
                    handWorth += cardValue;
                    Thread.Sleep(250);
                    Console.WriteLine("Your hand is now worth " + handWorth);

                    if (handWorth > 21)
                    {
                        Thread.Sleep(250);
                        Console.WriteLine("Your hand worth is " + handWorth + ". You lose the money you bet, leaving you with $" + money + ".");
                        Console.BackgroundColor = ConsoleColor.Red;
                        Thread.Sleep(250);
                        Console.WriteLine("You lose $" + amountBet + ".");
                        Console.BackgroundColor = ConsoleColor.Black;
                        Thread.Sleep(250);
                        Console.WriteLine("The dealer had a " + dcardName + ", worth " + dcardValue + ", and a " + dcardName2 + ", worth " + dcardValue2 + ", giving the dealer a total of " + dHandWorth + ".");
                        playing = false;
                        break;
                    }

                    Thread.Sleep(250);
                    Console.WriteLine("Would you like to HIT or FOLD? If anything other than hit or fold is inputted, it will be counted as a fold."); // explained in the line, fix this!
                    if (Console.ReadLine().ToLower() == "hit") 
                    {
                        playing = true;
                        hitorFold = true;
                    }
                    if (Console.ReadLine().ToLower() == "fold") // you have to hit enter twice if you fold, fix somehow??
                    {
                        hitorFold = false;
                    }

                    if (hitorFold == true)
                    {
                        Thread.Sleep(100);
                        Console.WriteLine("You are given a card.");
                        Thread.Sleep(100);
                        Console.WriteLine("There are " + cardamount + " cards left in the deck.");
                        continue;
                    }
                    if (hitorFold == false)
                    {
                        Thread.Sleep(250);
                        Console.WriteLine("You fold, with a total hand worth of " + handWorth + ".");
                        folded = true;
                        while (folded == true)
                        {

                            if (dHandWorth < 17 || handWorth == 21 && dHandWorth >= 17 || folding == true)
                            {
                                Thread.Sleep(250);
                                Console.WriteLine("The dealer draws a card."); // sometimes the dealer infinitely draws a card until the deck runs dry
                                Random rnd4 = new Random();                    // this might be an issue that i do not know how to fix 
                                int dcard3 = rnd4.Next(0, cards.Count);
                                int dcardValue3 = cards.ElementAt(dcard3).Value; string dcardName3 = cards.ElementAt(dcard3).Key;
                                cards.Remove(dcardName3, out dcardValue3);
                                dHandWorth = dcardValue + dcardValue2 + dcardValue3; // ok so the thing is that this causes that

                                if (dHandWorth >= handWorth)
                                {
                                    Thread.Sleep(100);
                                    Console.WriteLine("The dealer stops drawing. His hand is worth " + dHandWorth + ".");
                                    break;  
                                }
                                Thread.Sleep(100);
                                Console.WriteLine("The dealer draws a " + dcardName3 + ", worth " + dcardValue3 + ".");
                                Thread.Sleep(100);
                                Console.WriteLine("The dealer draws another card."); 
                                Random rnd5 = new Random();                    
                                int dcard4 = rnd5.Next(0, cards.Count);
                                int dcardValue4 = cards.ElementAt(dcard4).Value; string dcardName4 = cards.ElementAt(dcard4).Key;
                                cards.Remove(dcardName4, out dcardValue4);
                                dHandWorth = dcardValue + dcardValue2 + dcardValue3 + dcardValue4;
                                Thread.Sleep(100);
                                Console.WriteLine("The dealer draws a " + dcardName4 + ", worth" + dcardValue4 + ".");
                                Thread.Sleep(100);
                                if (dHandWorth >= handWorth)
                                {
                                    Thread.Sleep(100);
                                    Console.WriteLine("The dealer stops drawing. His hand is worth " + dHandWorth + ".");
                                    break;
                                }
                                Thread.Sleep(100);
                                Console.WriteLine("The dealer draws another card.");
                                Random rnd6 = new Random();
                                int dcard5 = rnd6.Next(0, cards.Count);
                                int dcardValue5 = cards.ElementAt(dcard5).Value; string dcardName5 = cards.ElementAt(dcard5).Key;
                                cards.Remove(dcardName5, out dcardValue5);
                                dHandWorth = dcardValue + dcardValue2 + dcardValue3 + dcardValue4 + dcardValue5;
                                Thread.Sleep(100);
                                Console.WriteLine("The dealer draws a " + dcardName5 + ", worth" + dcardValue5 + ".");
                                Thread.Sleep(100);
                                if (dHandWorth >= handWorth)
                                {
                                    Thread.Sleep(100);
                                    Console.WriteLine("The dealer stops drawing. His hand is worth " + dHandWorth + ".");
                                    break;
                                }
                                Thread.Sleep(100);
                                Console.WriteLine("The dealer draws another card.");
                                Random rnd7 = new Random();
                                int dcard6 = rnd7.Next(0, cards.Count);
                                int dcardValue6 = cards.ElementAt(dcard6).Value; string dcardName6 = cards.ElementAt(dcard6).Key;
                                cards.Remove(dcardName6, out dcardValue6);
                                dHandWorth = dcardValue + dcardValue2 + dcardValue3 + dcardValue4 + dcardValue5 + dcardValue6;
                                Thread.Sleep(100);
                                Console.WriteLine("The dealer draws a " + dcardName5 + ", worth" + dcardValue5 + ".");
                                if (dHandWorth >= handWorth)
                                {
                                    Thread.Sleep(100);
                                    Console.WriteLine("The dealer stops drawing. His hand is worth " + dHandWorth + ".");
                                    break;
                                }

                                if (dHandWorth > 21 && handWorth <= 21)
                                {
                                    money += amountBet * 2;
                                    Console.WriteLine("The dealer's hand is worth " + dHandWorth + ", while yours is worth " + handWorth + ".");
                                    Thread.Sleep(100);
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("You win $" + amountBet * 2 + ".");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    playing = false;
                                    break;
                                }
                                else if (dHandWorth == 21 && handWorth != 21)
                                {
                                    Console.WriteLine("The dealer's hand is worth 21, meaning the dealer scored a blackjack. The dealer takes your money, leaving you with $" + money + ".");
                                    Thread.Sleep(100);
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("You lose $" + amountBet + ".");
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    playing = false;
                                    break;
                                }
                                else if (dHandWorth == 21 && handWorth == 21)
                                {
                                    Console.WriteLine("The dealer and you both scored a blackjack. This concludes with a draw. You keep your money, leaving you with $" + money + ".");
                                    Thread.Sleep(100);
                                    Console.BackgroundColor = ConsoleColor.Gray;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("You lose nothing. You get your $" + amountBet + " back.");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    playing = false;
                                    break;
                                }
                                else if (dHandWorth != 21 && handWorth == 21)
                                {
                                    money += amountBet * 3;
                                    Console.WriteLine("You scored a blackjack. You triple your bet amount, leaving you with $" + money + ".");
                                    Thread.Sleep(100);
                                    Console.BackgroundColor = ConsoleColor.Green;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("You win $" + amountBet * 3 + ".");
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    playing = false;
                                    break;
                                }
                                else if (dHandWorth == handWorth)
                                {
                                    money += amountBet;
                                    Thread.Sleep(100);
                                    Console.BackgroundColor = ConsoleColor.Gray;
                                    Console.ForegroundColor = ConsoleColor.Black;
                                    Console.WriteLine("Your hand and the dealer's hand are equal, ending the game in a draw. This leaves you with $" + money);
                                    Console.ForegroundColor = ConsoleColor.Gray;
                                    Console.BackgroundColor = ConsoleColor.Black;
                                    playing = false;
                                    break;
                                }

                            }
                            else if (dHandWorth >= 17)
                            {
                                Thread.Sleep(100);
                                Console.WriteLine("The dealer folds. His hand is worth " + dHandWorth + ".");
                                playing = false;
                                folding = true;
                                while (folding == true)
                                {
                                    if (dHandWorth > 21 && handWorth <= 21)
                                    {
                                        money += amountBet * 2;
                                        Thread.Sleep(100);
                                        Console.WriteLine("The dealer's hand is worth " + dHandWorth + ", while yours is worth " + handWorth + ". You double your bet amount, leaving you with $" + money + ".");
                                        Thread.Sleep(100);
                                        Console.BackgroundColor = ConsoleColor.Green;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("You win $" + amountBet * 2 + ".");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        playing = false;
                                        folding = false;
                                        break;
                                    }
                                    else if (dHandWorth == 21 && handWorth != 21)
                                    {
                                        Console.WriteLine("The dealer's hand is worth 21, meaning the dealer scored a blackjack. The dealer takes your money, leaving you with $" + money + ".");
                                        Thread.Sleep(100);
                                        Console.BackgroundColor = ConsoleColor.Red;
                                        Console.WriteLine("You lost $" + amountBet + ".");
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        playing = false;
                                        folding = false;
                                        break;
                                    }
                                    else if (dHandWorth == 21 && handWorth == 21)
                                    {
                                        money += amountBet;
                                        Console.WriteLine("The dealer and you both scored a blackjack. This concludes with a draw. You keep your money, leaving you with $" + money + ".");
                                        Thread.Sleep(100);
                                        Console.BackgroundColor = ConsoleColor.Gray;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("You lose nothing. You get your $" + amountBet + " back.");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        playing = false;
                                        folding = false;
                                        break;
                                    }
                                    else if (dHandWorth != 21 && handWorth == 21)
                                    {
                                        money += amountBet * 3;
                                        Console.WriteLine("You scored a blackjack. You triple your bet amount, leaving you with $" + money + ".");
                                        Thread.Sleep(100);
                                        Console.BackgroundColor = ConsoleColor.Green;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("You won $" + amountBet * 3 + ".");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        playing = false;
                                        folding = false;
                                        break;
                                    }
                                    else if (dHandWorth < handWorth && handWorth < 21)
                                    {
                                        money += amountBet * 2;
                                        Console.WriteLine("Your hand is worth more than the dealer's hand. You double your bet amount, leaving you with $" + money + ".");
                                        Thread.Sleep(100);
                                        Console.BackgroundColor = ConsoleColor.Green;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("You win $" + amountBet * 2 + ".");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        playing = false;
                                        folding = false;
                                        break;
                                    }
                                    else if (dHandWorth == handWorth)
                                    {
                                        money += amountBet;
                                        Console.WriteLine("Your hand and the dealer's hand are equal, ending the game in a draw. This leaves you with $" + money);
                                        Thread.Sleep(100);
                                        Console.BackgroundColor = ConsoleColor.Gray;
                                        Console.ForegroundColor = ConsoleColor.Black;
                                        Console.WriteLine("You lose nothing. You get your $" + amountBet + " back.");
                                        Console.ForegroundColor = ConsoleColor.Gray;
                                        Console.BackgroundColor = ConsoleColor.Black;
                                        playing = false;
                                        folding = false;
                                        break;
                                    }
                                    break;
                                }
                            }

                            else
                            {
                                Thread.Sleep(100);
                                Console.WriteLine("Unrecognised word. Please input HIT or FOLD.");
                                continue;
                            }
                            }
                        }
                    }
                }
            }
        }
    }