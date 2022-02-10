using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Stage_Scancube.Test1
{
   
    internal class Turntable : AllObject
    {
        
        Guid id;
        String sorti = "I'm a Turntable";
       public Turntable()
        {
            GenerateId();
        }
        public String GetInfo()
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
