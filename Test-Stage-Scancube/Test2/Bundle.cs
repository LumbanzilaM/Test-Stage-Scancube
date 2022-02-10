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
        private Lightbox lightbox;
        private Turntable turntable;
        private Camera camera;

        public Bundle()
        {
          this.lightbox=new Lightbox();
          this.turntable=new Turntable();
          this.camera=new Camera();
       }

        public string Owner { get; set; }


    }
}
