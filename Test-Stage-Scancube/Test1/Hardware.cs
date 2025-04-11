using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Stage_Scancube.Test1
{
    public class Lightbox
    {
        public Lightbox() { }
        public string GetInfo()
        {
            return "I'm a Lightbox";
        }
    }
    public class TurnTable
    {
        public TurnTable() { }
        public string GetInfo()
        {
            return "I'm a Turntable";
        }
    }
    public class Camera
    {
        public Camera() { }
        public string GetInfo()
        {
            return "I'm a Camera";
        }
    }
}
