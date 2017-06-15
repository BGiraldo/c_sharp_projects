using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementDataGridView
{
   public class Turn
    {
        private int numberTurn;

        private String document;

        private String date;

        public Turn(int numberTurn, string document, string date)
        {
            this.numberTurn = numberTurn;
            this.document = document;
            this.date = date;
        }

        public int NumberTurn { get => numberTurn; set => numberTurn = value; }
        public string Document { get => document; set => document = value; }
        public string Date { get => date; set => date = value; }
    }
}
