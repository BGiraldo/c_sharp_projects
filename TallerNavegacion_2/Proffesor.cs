using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerNavegacion_2
{
   public class Proffesor
    {

        private int id;

        private String completName;

        private String user;

        private String pass;

        private LinkedList<Signature> signatures;

        public Proffesor(int id, string completName, string user, string pass)
        {
            this.id = id;
            this.completName = completName;
            this.user = user;
            this.pass = pass;
            signatures = new LinkedList<Signature>();
        }

        public int Id { get => id; set => id = value; }
        public string CompletName { get => completName; set => completName = value; }
        public string User { get => user; set => user = value; }
        public string Pass { get => pass; set => pass = value; }
        internal LinkedList<Signature> Signatures { get => signatures; set => signatures = value; }
    }
}
