using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerNavegacion_2
{
    public class Grade
    {

        private float grade;

        private float porcent;

        public Grade(float grade, float porcent)
        {
            this.grade = grade;
            this.porcent = porcent;
        }

        public float GradeN { get => grade; set => grade = value; }
        public float Porcent { get => porcent; set => porcent = value; }
    }
}
