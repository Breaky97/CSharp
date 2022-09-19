//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TextBasedGame
//{

//    class Game
//    {
//        // Vars

//        private bool end;
//        public bool End { 
//            get { return this.end; }
//            set { this.end = value; }
//        }

//        private Stack<State> states;

//        // Private funcs

//        private void initVars()
//        {
//            this.end = false;
//        }

//        private void initStates()
//        {
//            this.states = new Stack<State>();

//            // push the first state
//            this.states.Push(new StateMainMenu(this.states));
//        }

//        // constr i destruct
        
//        public Game()
//        {
//            this.initVars();
//            this.initStates();
//            Console.WriteLine("Hello from the game class.");
//        }
        
//        public void Run()
//        {
//            while(this.end == false)
//            {
//                Console.WriteLine("Input a number: ");
//                int number = Convert.ToInt32(Console.ReadLine());

//                if (number < 0)
//                    this.end = true;
//                else
//                    Console.WriteLine("Your input was {0}.", number);
//            }
//            Console.WriteLine("Session has ended.");
//        }
//    }
//}
