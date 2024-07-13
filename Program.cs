using System;

namespace DerryIsAnEnglishTeacher
{
    class SuperSpookyTerminalGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First of, do you wanna play this super spooky game?");

            string? resp_1 = Console.ReadLine();

            resp_1 = resp_1.ToLower();

            if (resp_1 == "no")
            {
                Console.WriteLine("Ending 0/6");
                Thread.Sleep(1000);
                Console.WriteLine("The 'too scared' ending.");
                Thread.Sleep(1000);
                TryAgain();
            }
            else if (resp_1 == "yes")
            {
                Console.WriteLine("Alright.");
                Thread.Sleep(1000);
                Console.WriteLine("It was a gloomy and stormy night..");
                Thread.Sleep(850);
                Console.WriteLine("Until you heard a *SLAM*!");
                Thread.Sleep(1200);
                Console.WriteLine("You hear thumping coming from down the hall.");
                Thread.Sleep(600);
                Console.WriteLine("Do you go investigate or go back to sleep?");
                
                string? resp_2 = Console.ReadLine();

                resp_2 = resp_2.ToLower();

                if (resp_2 == "sleep" || resp_2 == "back to sleep" || resp_2 == "stay")
                {
                    Thread.Sleep(500);
                    Console.WriteLine("You shut your tired eyes, it was probably nothing anyways.");
                    Thread.Sleep(655);
                    Console.WriteLine("The thumping is getting closer, it's probably your parents..");
                    Thread.Sleep(700);
                    Console.WriteLine("You hear your doorknob twisting, again, probably your parents checking on you..");
                    Thread.Sleep(800);
                    Console.WriteLine("Quiet footsteps walk toward your bed, each creek getting louder.");
                    Thread.Sleep(900);
                    Console.WriteLine("Until..");
                    Thread.Sleep(1000);
                    Console.WriteLine("What do you do? Stay still and pretend to be sleeping, or turn around and see?");

                    string? resp_3 = Console.ReadLine();

                    resp_3 = resp_3.ToLower();

                    if (resp_3 == "stay" || resp_3 == "sleep" || resp_3 == "pretend")
                    {
                        Thread.Sleep(750);
                        Console.WriteLine("You stay as still as a statue..");
                        Thread.Sleep(650);
                        Console.WriteLine("Your heart is beating fast..");
                        Thread.Sleep(650);
                        Console.WriteLine("You feel whatever is behind you grab the back of your head..");
                        Thread.Sleep(730);
                        Console.WriteLine("In a moment you hear a *CRUNCH* and you black out immediately.");
                        Thread.Sleep(800);
                        Console.WriteLine("Ending 1/6");
                        Thread.Sleep(1000);
                        Console.WriteLine("The 'Sleeping Corpse' ending.");
                        Thread.Sleep(1000);
                        TryAgain();
                    }
                    else if (resp_3 == "turn" || resp_3 == "look back" || resp_3 == "look")
                    {

                        Thread.Sleep(1000);
                        Console.WriteLine("Your curiosity takes over and you look behind you to see and...");
                        Thread.Sleep(1500);
                        Console.WriteLine("You see nothing..");
                        Thread.Sleep(1000);
                        Console.WriteLine("Ending 2/6");
                        Thread.Sleep(1000);
                        Console.WriteLine("The 'Mind Tricks' ending.");
                        Thread.Sleep(1000);
                        TryAgain();
                    }
                }
                else if (resp_2 == "investigate" || resp_2 == "check" || resp_2 == "look")
                {
                    Thread.Sleep(750);
                    Console.WriteLine("As you slowly open the door and peek down the hall..");
                    Thread.Sleep(1000);
                    Console.WriteLine("You see the cloest door all the way down the hall slowly shut.");
                    Thread.Sleep(1000);
                    Console.Write("Do you go to your parents room? or go towards the closet down the hall? ");

                    string? resp_4 = Console.ReadLine();

                    resp_4 = resp_4.ToLower();

                    if (resp_4 == "parents" || resp_4 == "parents room" || resp_4 == "parent" || resp_4 == "parent room")
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("Your walking down the hall, towards your parents room..");
                        Thread.Sleep(1200);
                        Console.WriteLine("You open the door to find neither of them in bed.");
                        Thread.Sleep(1350);
                        Console.WriteLine("That's weird. You look around and don't spot anyone.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Ending 3/6");
                        Thread.Sleep(1000);
                        Console.WriteLine("The 'All Alone' ending.");
                        Thread.Sleep(1000);
                        TryAgain();
                    }
                    else if (resp_4 == "closet" || resp_4 == "down the hall" || resp_4 == "closet door")
                    {
                        Thread.Sleep(1000);
                        Console.WriteLine("Your walking down the hall, towards the closet..");
                        Thread.Sleep(1000);
                        Console.WriteLine("You approach the door.");
                        Thread.Sleep(1000);
                        Console.WriteLine("Do you knock or try to open it?");

                        string? resp_5 = Console.ReadLine();

                        resp_5 = resp_5.ToLower();

                        if (resp_5 == "knock")
                        {
                            Thread.Sleep(1000);
                            Console.WriteLine("You knock, you hear a voice start talking. It's not one you recognize.");
                            Thread.Sleep(1560);
                            Console.WriteLine("'The rich need it, the poor have it. If you eat it you die. What's the answer?'");

                            string? resp_6 = Console.ReadLine();

                            resp_6 = resp_6.ToLower();

                            if (resp_6 == "nothing")
                            {
                                Thread.Sleep(1200);
                                Console.WriteLine("You hear a click behind the door..");
                                Thread.Sleep(1666);
                                Console.WriteLine("You twist the door knob, the door opens revealing..");
                                Thread.Sleep(1250);
                                Console.WriteLine("Nothing..");
                                Thread.Sleep(1000);
                                Console.WriteLine("Ending 4/6");
                                Thread.Sleep(1000);
                                Console.WriteLine("The 'Ghostly Janitor' ending.");
                                Thread.Sleep(1000);
                                TryAgain();
                            }
                            else
                            {
                                Thread.Sleep(1555);
                                Console.WriteLine("The air gets heavier..");
                                Thread.Sleep(1450);
                                Console.WriteLine("The door opens slowly..");
                                Thread.Sleep(1650);
                                Console.WriteLine("You try to get a glipse of what has been disturbing you until..");
                                Thread.Sleep(1700);
                                Console.WriteLine("You hear a low voice mutter, 'Incorrect..'");
                                Thread.Sleep(1777);
                                Console.WriteLine("In a moment the creature slashes you on the face!");
                                Thread.Sleep(1000);
                                Console.WriteLine("The door slams shut, this time when you try to knock nothing happens.");
                                Thread.Sleep(1000);
                                Console.WriteLine("Ending 5/6");
                                Thread.Sleep(1000);
                                Console.WriteLine("The 'Should Have Stayed Asleep' ending.");
                                TryAgain();
                            }
                        }
                        else if (resp_5 == "open")
                        {
                            Thread.Sleep(1500);
                            Console.WriteLine("You twist the door knob, just to find it's locked.");
                            Thread.Sleep(1666);
                            Console.WriteLine("You do see the key on the floor right outside the door!");
                            Thread.Sleep(1500);
                            Console.WriteLine("You use the key and open the door, revealing...");
                            Thread.Sleep(1000);
                            Console.WriteLine("Nothing..");
                            Thread.Sleep(1000);
                            Console.WriteLine("Ending 6/6");
                            Thread.Sleep(1000);
                            Console.WriteLine("The 'Nothing' ending.");
                            Thread.Sleep(1000);
                            TryAgain();
                        }
                    }
                }
            }
        }
        static void TryAgain()
        {
            Thread.Sleep(1666);
            Console.WriteLine("Do you want to try again?");

            string? answer = Console.ReadLine();

            answer = answer.ToLower();

            if (answer == "yes")
            {
                Main([""]);
            }
            else
            {
                Thread.Sleep(1000);
                Console.WriteLine("Ah, I see. Too scared.");
            }
        }
    }
}
// I'm expecting my personal English teach to fork this to fix 'grammatical errors'.
