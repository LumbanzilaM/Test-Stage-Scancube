using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Stage_Scancube.Test1
{
    public class HardwareGenerator
    {
        public enum Type
        {
            Lightbox,
            TurnTable,
            Camera
        };

        public IHardware CreateObject(Type _type)
        {
            switch (_type)
            {
                case Type.Lightbox:
                    return new Lightbox();
                case Type.TurnTable:
                    return new TurnTable();
                case Type.Camera:
                    return new Camera();
                default:
                    throw new ArgumentException("Argument not supported");
            }
        }

        public string[] GetAllInfos()
        {
            //------------------A modifier--------------------

            IHardware lightbox = (Lightbox)CreateObject(Type.Lightbox);
            IHardware turntable = (TurnTable)CreateObject(Type.TurnTable);
            IHardware camera = (Camera)CreateObject(Type.Camera);

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
