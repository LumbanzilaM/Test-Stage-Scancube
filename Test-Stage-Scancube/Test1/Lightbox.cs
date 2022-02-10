using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Stage_Scancube.Test1
{
    internal class Lightbox : AllObject
    {
        String sorti = "I'm a Light";
        Guid id;//elle est déja static guid
        public Lightbox() { GenerateId(); }
        public string GetInfo()
        {
            return sorti;
        }
        public void GenerateId()
        {
            id = Guid.NewGuid();
        }
        public Guid getId()
        {
            return id;
        }
    }
}
