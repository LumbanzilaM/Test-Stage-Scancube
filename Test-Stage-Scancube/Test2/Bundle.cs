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
        private Camera camera;
        private Lightbox Lightbox;
        private TurnTable turnTable;
        public Bundle( string owner, Camera camera, Lightbox Lightbox, TurnTable turnTable)
        {
            owner = owner;
            camera = camera;
            Lightbox = Lightbox;
            turnTable = turnTable;
        }

        public string Owner { get; set; }
        
    }
}
