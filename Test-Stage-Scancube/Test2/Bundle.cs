using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Stage_Scancube.Test1;
using Test_Stage_Scancube.Test2;

namespace Test_Stage_Scancube.Test2
{
    public class Bundle
    {
        public Lightbox Lightbox { get; set; }
        public TurnTable Turntable { get; set; }
        public Camera Camera { get; set; }
        public Bundle(string owner)
        {
            Owner = owner;
            Lightbox = new Lightbox();
            Turntable = new TurnTable();
            Camera = new Camera();
        }

        public string Owner { get; set; }

    }
}
