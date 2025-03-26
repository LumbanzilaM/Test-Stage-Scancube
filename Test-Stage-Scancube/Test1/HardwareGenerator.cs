using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Stage_Scancube.Test1
{

    public class Lightbox
    {
    
        public string GetInfo()
        {
            return "I'm a Lightbox";
        }
    }

    public class Turntable
    {
        public string GetInfo()
        {
            return "I'm a Turntable";
        }
    }
    public class Camera
    {
        public string GetInfo()
        {
            return "I'm a Camera";
        }
    }



    public class HardwareGenerator
    {
        //public T CreateObjectOpti<T>() where T : new()
        //{
        //    return new T();
        //}

        public object CreateObject (string type)
        {
            if (type == "Lightbox")
            {
                return new Lightbox();
            }

            if (type == "Turntable")
            {
                return new Turntable();
            }

            if (type == "Camera")
            {
                return new Camera();
            }
            return (object)null;
        }

        public string[] GetAllInfos()
        {

            //------------------A modifier--------------------

            Lightbox lightbox = (Lightbox)CreateObject("Lightbox");
            Turntable turntable = (Turntable)CreateObject("Turntable");
            Camera camera = (Camera)CreateObject("Camera");

            //Lightbox lightbox = CreateObjectOpti<Lightbox>();
            //Turntable turntable = (Turntable)CreateObject("Turntable");
            //Camera camera = (Camera)CreateObject("Camera");

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
