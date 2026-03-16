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
        public Bundle()
        {
        }

        public string Owner { get; set; }

        public Camera Camera { get; set; } = new Camera();
        public Lightbox Lightbox { get; set; } = new Lightbox();
        public TurnTable Turntable { get; set; } = new TurnTable();

    }
}
