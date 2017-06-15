using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementDataGridView
{
    
    class TurnController
    {

        private LinkedList<Turn> turns;


        public TurnController()
        {
            turns = new LinkedList<Turn>();
        }

        public void addTurn(Turn turn)
        {
            turns.AddLast(turn);
        }

       
        public bool removeTurn(String number)
        {
            foreach(var t in turns)
            {
                if (t.NumberTurn.Equals(number))
                {
                    turns.Remove(t);
                    return true;
                }
            }
            return false;
        }
     
        public int obtainTurn()
        {
            if (turns.Count == 0)
            {
                return 0;
            }

            return turns.Last().NumberTurn+1;
        }



    }
}
