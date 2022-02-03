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
        public Camera Camera { get; set; }
        public Lightbox Lightbox { get; set; }
        public Turntable Turntable { get; set; }
        public Bundle(string owner, Camera camera, Lightbox Lightbox, Turntable turnTable)
        {
            this.Owner = owner;
            this.Camera = camera;
            this.Lightbox = Lightbox;
            this.Turntable = turnTable;
        }

        public string Owner { get; set; }
        
    }
}
