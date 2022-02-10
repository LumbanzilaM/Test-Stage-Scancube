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
        public Camera Camera { get; private set; }
        public Lightbox Lightbox { get; private set; }
        public TurnTable Turntable { get; private set; }

        public Bundle()
        {
            this.Camera = new Camera();
            this.Lightbox = new Lightbox();
            this.Turntable = new TurnTable();
            this.Owner = "";
        }
        public Bundle(String Owner)
        {
            this.Camera = new Camera();
            this.Lightbox = new Lightbox();
            this.Turntable = new TurnTable();
            this.Owner = Owner;
        }

        public string Owner { get; set; }

    }
}
