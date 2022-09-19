using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBasedGame
{
    class StateMainMenu : State
    {
        public StateMainMenu(Stack<State> states):base(states)
        {
            Console.WriteLine("Hello from MainMenu.");
        }

    }
}
