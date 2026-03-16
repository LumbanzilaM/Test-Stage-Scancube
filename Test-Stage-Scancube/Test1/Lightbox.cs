using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Stage_Scancube.Test1
{
    public class Lightbox
    {
        static int id = 0;
        public int Id { get; set; }

        public int GenerateId()
        {
            Id++;
            return Id;
        }

        public string GetInfo()
        {
            return "I'm a Lightbox";
        }
    }
}
