using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Stage_Scancube.Test1
{
    public class Camera
    {
        private static int id;
        public int Id { get; set; }
        

        public Camera()
        {
            Id = GenerateId();
        }

        public int GenerateId()
        {
            id++;
            return id;
        }

        public string GetInfo()
        {
            return "I'm a Camera";
        }
    }
}
