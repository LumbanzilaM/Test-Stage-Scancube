using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test_Stage_Scancube.Test1;

namespace Test_Stage_Scancube.Test1
{
    public class HardwareGenerator
    {
        public string[] GetAllInfos()
        {
            //------------------A modifier--------------------

            Lightbox lightbox = new Lightbox();
            TurnTable turntable = new TurnTable();
            Camera camera = new Camera();

            // -----------------------------------------------

            //---------A décommenter (mais pas modifier)---------

            string[] infos = new string[]
            {
                lightbox.GetInfo(),
                turntable.GetInfo(),
                camera.GetInfo()
            };
            return infos;

            //---------------------------------------------------
        }
    }
}
