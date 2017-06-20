using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerNavegacion_2
{
    class SignatureController
    {

        public SignatureController()
        {
            
        }

        public bool addSignature(Signature signature)
        {
            foreach(var s in LoginController.proffesor.Signatures)
            {
                if (s.Code.Equals(signature.Code))
                {
                    return false;
                }
            }

            LoginController.proffesor.Signatures.AddLast(signature);
            return true; 
        }

        public Signature searchSubject(String code)
        {
            foreach(var s in LoginController.proffesor.Signatures)
            {
                if (s.Code.Equals(code))
                {
                    return s;
                }
            }
            return null;
        }





    }
}
