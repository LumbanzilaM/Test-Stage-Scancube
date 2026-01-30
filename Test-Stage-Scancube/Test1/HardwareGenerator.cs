using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Stage_Scancube.Test1
{
    public class Object
    {
        protected string info;
        public uint Id { get; set; }

        public Object(string info, uint id)
        {
            this.info = info;
            this.Id = id;
        }

        public string GetInfo()
        {
            return info; 
        }
    }

    public class Lightbox : Object
    {
        static uint id_counter = 0;

        public Lightbox() : base("I'm a Lightbox", id_counter++) {}

    }
    
    public class TurnTable : Object
    {
        static uint id_counter = 0;
        public TurnTable() : base("I'm a Turntable", id_counter++) {}

    }

    public class Camera  : Object
    {
        static uint id_counter = 0;

        public Camera() : base("I'm a Camera", id_counter++) {}

    }

    public class HardwareGenerator
    {
       
        private Object CreateObject(int type)
        {
            switch (type) {
                case 1:
                    return new Lightbox();
                case 2:
                    return new TurnTable();
                case 3:
                    return new Camera();
                default:
                    return null;
                    // return new Object("I'm an Invalid Object", 0);
            }
        }

        public string[] GetAllInfos()
        {
            //------------------A modifier--------------------

            Lightbox lightbox = (Lightbox)CreateObject(1);
            TurnTable turntable = (TurnTable)CreateObject(2);
            Camera camera = (Camera)CreateObject(3); 

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
