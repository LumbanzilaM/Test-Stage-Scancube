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
    public int Id;

    public int GenerateId()
    {
        var IdG = (DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1));
        return (int)(IdG.TotalMilliseconds + 0.5);
    }
    public Lightbox(int Id)
    {
        this.Id = this.GenerateId();
    }
    public string GetInfo()
    {
        String light = "I'm a Lightbox";
        return light;

    }
}
class TurnTable
{
    public int Id;
    public int GenerateId()
    {
        var IdG = (DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1));
        return (int)(IdG.TotalMilliseconds + 0.5);
    }
    public TurnTable()
    {
    }

    public TurnTable(int Id)
    {
        this.Id = this.GenerateId();
    }
    public string GetInfo()
    {
        
        String turn = "I'm a Turntable";
        return turn;
    }
}
class Camera
{
    public int Id;

    public Camera()
    {
    }
    public int GenerateId()
    {
        var IdG = (DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1));
        return (int)(IdG.TotalMilliseconds + 0.5);
    }

    public Camera(int Id)
    {
        this.Id = this.GenerateId();


    }
    public  string GetInfo()
    {
        String camera= "I'm a Camera";
        return camera;
    }
}
