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
class Lightbox
{
   public string GetInfo()
    {

        String light = "I'm a Lightbox";
        return light;

    }
}
class TurnTable
{
    public string GetInfo()
    {
       
        String turn = "I'm a Turntable";
        return turn;
    }
}
class Camera
{
    public  string GetInfo()
    {
        String camera= "I'm a Camera";
        return camera;
    }
}