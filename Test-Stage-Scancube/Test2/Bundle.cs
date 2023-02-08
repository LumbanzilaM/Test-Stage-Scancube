using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Stage_Scancube.Test1;

namespace Test_Stage_Scancube.Test2
{
    public class Bundle
    {
        public Lightbox Lightbox { get; set; }
        public TurnTable Turntable { get; set; }
        public Camera Camera { get; set; }

        public Bundle()
        {
            Lightbox = lb;
            Turntable = tb;
            Camera = cm;
        }

        public string Owner { get; set; }

    }
}
