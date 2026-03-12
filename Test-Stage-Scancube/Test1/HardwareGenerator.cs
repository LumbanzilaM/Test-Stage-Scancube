using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Stage_Scancube.Test1
{
    public interface IObject
    {
        string GetInfo();
    }

    public class AObject : IObject
    {
        public virtual string GetInfo()
        {
            return "";
        }
    }

    public class Lightbox : AObject
    {
        // Ajouter une paire de type d'objet (string) avec un nombre (int) pour l'id. (test.02)
        public string GetInfo()
        {
            return "I'm a Lightbox";
        }
    }

    public class Turntable : AObject
    {
        public string GetInfo()
        {
            return "I'm a Turntable";
        }
    }

    public class Camera : AObject
    {
        public string GetInfo()
        {
            return "I'm a Camera";
        }
    }

    public delegate IObject createObj();
    public struct objectTable
    {
        public string objName;
        createObj objectCreation;
    }

    public objectTable[NB_OBJ] associativeTabObj =
    {
        { "Lightbox", new Lightbox },
        { "Turntable", new Turntable },
        { "Camera", new Camera }
    };

    public enum Objects_e
    {
        LIGHTBOX = 0,
        TURNTABLE,
        CAMERA,
        NB_OBJ
    };

    public class ObjectFactory
    {
        public IObject CreateObject(string objectName)
        {
            for (int i = 0; i < NB_OBJ; ++i)
                if (objectName == objectTable[i].objName)
                    return objectTable[i].objectCreation();
            throw new Exception("No such object exist.");
        }
    }

    public class HardwareGenerator
    {
       

        public string[] GetAllInfos()
        {
            //------------------A modifier--------------------

            Lightbox lightbox = CreateObject("Lightbox");
            Turntable turntable = CreateObject("Turntable");
            Camera camera = CreateObject("Camera");

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
