using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace StatePatternExerciseStub
{
    class CommandHelper
    {
        public static readonly string PLAY = "play";
        public static readonly string STOP = "stop";
        public static readonly string PAUSE = "pause";

        private static bool isCommand(string input, string commandStr)
        {
            return string.Compare(input, commandStr, true) == 0;
        }

        public static Command StrToCommand(string input)
        {
            if(isCommand(input, PLAY)){
                return Command.PLAY;
            } 
            else if (isCommand(input, PAUSE))
            {
                return Command.PAUSE;
            } 
            else if (isCommand(input, STOP))
            {
                return Command.STOP;
            }

            return Command.INVALID;
                
        }

        public static bool IsACommand(string cmd)
        {
            return StrToCommand(cmd) != Command.INVALID;
        }

        public enum Command
        {
            PLAY, PAUSE, STOP, INVALID
        }
    }
}
