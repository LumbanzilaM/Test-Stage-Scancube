using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Stage_Scancube.Test1
{

    internal class Camera : AllObject
    {
        //private static final AtomicInteger idGenerator = new AtomicInteger(1000);

        // private final Integer id;

        /*public Coordinates()
            {
                //donner un unique id pour une instance
                id = idGenerator.getAndIncrement();
            }
        */


        //private static readonly int idGenerator = ; 
        //Guid
        public Guid id;
        public String sorti = "I'm a Camera";
        public Camera() { GenerateId(); }
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
