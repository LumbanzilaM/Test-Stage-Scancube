using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Stage_Scancube.Test1
{
    public class HardwareGenerator
    {
       

        public T CreateObject<T>() where T : new()
        {
            return new T();
        }


        public string[] GetAllInfos()
        {
            //------------------A modifier--------------------

            //Lightbox lightbox = Votre méthode 'CreateObject'
            //TurnTable turntable = Votre méthode 'CreateObject'
            //Camera camera = Votre méthode 'CreateObject'

            // -----------------------------------------------

            //---------A décommenter (mais pas modifier)---------

            string[] infos = new string[]
            {
                //lightbox.GetInfo(),
                //turntable.GetInfo(),
                //camera.GetInfo()
            };
            return infos;

            //---------------------------------------------------
        }
    }
}
