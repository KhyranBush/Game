using System.Collections;
using System.Collections.Generic;

namespace TheTreeOfLife
{
    public class HelpCommand : Command
    {
        private CommandWords _words;

        public HelpCommand() : this(new CommandWords()){}

        // Designated Constructor
        public HelpCommand(CommandWords commands) : base()
        {
            _words = commands;
            this.Name = "help";
        }

        override
        public bool Execute(Player player)
        {
            if (this.HasSecondWord())
            {
                player.OutputMessage("\nI cannot help you with " + this.SecondWord);
            }
            else
            {
                player.OutputMessage("\nYou are lost as you are in a different place than when you were awake " +"\n\nYou long to pick up the pieces of the remnants of your old life\n\n"+ "You can do the following actions to aid you ascension to freedom... " + _words.Description());
            }
            return false;
        }
    }
}
