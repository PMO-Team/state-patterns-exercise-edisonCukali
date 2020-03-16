using System;

namespace StatePatternExerciseStub
{
    class Program
    {
        static MediaPlayer player;

        static void Main(string[] args)
        {
            Console.WriteLine("Insert the song title:");
            string songTitle = Console.ReadLine();
            Console.WriteLine($"{songTitle} loaded");

            player = new MediaPlayer(songTitle);

            bool exitFlag = false;

            while (!exitFlag)
            {
                var action = GetUserAction();
                exitFlag = PerformAction(action);

            }

            Console.WriteLine("Player unloaded!");
            Console.WriteLine("Bye Bye");

        }

        private static bool PerformAction(CommandHelper.Command action)
        {
            bool exit = false;
            switch (action)
            {
                case CommandHelper.Command.PLAY:
                    Console.WriteLine("PLAY command received");
                    player.Play();
                    break;
                case CommandHelper.Command.PAUSE:
                    Console.WriteLine("PAUSE command received");
                    player.Pause();
                    break;
                case CommandHelper.Command.STOP:
                    Console.WriteLine("STOP command received");
                    exit = player.Stop();
                    break;
            }

            return exit;
        }

        private static CommandHelper.Command GetUserAction() {

            string action;
            do
            {
                Console.WriteLine("What do you want to do? (play/pause/stop)");
                Console.Write(">> ");
                action = Console.ReadLine();
            } while (!CommandHelper.IsACommand(action));

            return CommandHelper.StrToCommand(action);

        }
    }
}
