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

            Lightbox lightbox = CreateObject<Lightbox>();
            Turntable turntable = CreateObject<Turntable>();
            Camera camera = CreateObject<Camera>();

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


public abstract class Hardware
{
    public Guid Id { get; set; }

    public Hardware()
    {
        this.Id = GenerateId();
    }

    public Guid GenerateId()
    {
        //var IdG = (DateTime.Now.ToUniversalTime() - new DateTime(1970, 1, 1));
        //return (int)(IdG.TotalMilliseconds + 0.5);
        return Guid.NewGuid();
    }

    public string GetInfo()
    {
        String light = $"I'm a {this.GetType().Name}";
        return light;

    }

}

public class Lightbox : Hardware
{
}

public class Turntable : Hardware
{
}

public class Camera : Hardware
{
}
