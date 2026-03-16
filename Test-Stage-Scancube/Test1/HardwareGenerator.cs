using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Stage_Scancube.Test1
{
    public class HardwareGenerator
    {


        public string[] GetAllInfos()
        {
            //------------------A modifier--------------------

            Lightbox lightbox = CreateObjet<Lightbox>();
            TurnTable turntable = CreateObjet<TurnTable>();
            Camera camera = CreateObjet<Camera>();

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


        public T CreateObjet<T>() where T : new()
        {
            return new T();
        }
    }
}