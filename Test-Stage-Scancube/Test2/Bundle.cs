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

        public Bundle(string Owner)
        {
            this.Owner = Owner;
            this.Camera = new Camera();
            this.TurnTable = new TurnTable();
            this.Lightbox = new Lightbox ();
        }

        public Camera Camera { get; set; }
        public TurnTable TurnTable { get; set; }
        public Lightbox Lightbox { get; set; }

        public string Owner { get; set; }

    }
}
