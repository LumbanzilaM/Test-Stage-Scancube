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
        public Bundle(string _owner)
        {
            Owner = _owner;
            Camera = new CCamera();
            Lightbox = new CLightbox();
            Turntable = new CTurnTable();
        }

        public CCamera Camera { get; set; }
        public CLightbox Lightbox { get; set; }
        public CTurnTable Turntable { get; set; }

        public string Owner { get; set; }
    }
}
