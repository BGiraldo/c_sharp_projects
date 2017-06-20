using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerNavegacion_2
{
    class Signature
    {

        private String code;

        private String name;

        private Grade[] studioGrades;

        private Grade[] partialGrades;

        private float definitive;

        public Signature(string code, string name, Grade[] studioGrades, Grade[] partialGrades)
        {
            this.code = code;
            this.name = name;
            this.studioGrades = studioGrades;
            this.partialGrades = partialGrades;
            definitive = 0;
        }

        public string Code { get => code; set => code = value; }
        public string Name { get => name; set => name = value; }
        public Grade[] StudioGrades { get => studioGrades; set => studioGrades = value; }
        public Grade[] PartialGrades { get => partialGrades; set => partialGrades = value; }
        public float Definitive { get => definitive; set => definitive = value; }
    }
}
