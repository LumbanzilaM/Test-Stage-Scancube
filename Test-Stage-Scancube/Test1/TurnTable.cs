using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Stage_Scancube.Test1
{

    // j'aurai pu creer une interface pour les 3 classes mais j'y ai penser trop tard
    public class TurnTable
    {
        // l'idee est de creer une static pour que la valeur soit partager mais ca n'a pas l'air de fonctionner
        public Guid Id{ get; set; }

        public Guid GenerateId()
        {
            Id = System.Guid.NewGuid();
            return Id;
        }
        public string GetInfo()
        {
            return "I'm a Turntable";
        }

    }
}
