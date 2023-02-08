using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Stage_Scancube.Test1
{
    public class Lightbox
    {
        public int Id;
        private int Id_counter = 0;

        public string GetInfo()
        {
            return "I'm a Lightbox";
        }

        public int GenerateId()
        {
            Id_counter ++;
            return Id_counter;
        }

        public Lightbox()
        {
            Id = GenerateId();
        }
    }



    public class TurnTable
    {
        public int Id;
        private int Id_counter = 0;

        public string GetInfo()
        {
            return "I'm a Turntable";
        }

        public int GenerateId()
        {
            Id_counter++;
            return Id_counter;
        }

        public TurnTable()
        {
            Id = GenerateId();
        }
    }

    public class Camera
    {
        public int Id;
        private int Id_counter = 0;

        public string GetInfo()
        {
            return "I'm a Camera";
        }

        public int GenerateId()
        {
            Id_counter++;
            return Id_counter;
        }

        public Camera()
        {
            Id = GenerateId();
        }
    }

    public class HardwareGenerator
    {
       

        public string[] GetAllInfos()
        {
            Lightbox lightbox = new Lightbox();
            TurnTable turntable = new TurnTable();
            Camera camera = new Camera();
            //------------------A modifier--------------------

            //Lightbox lightbox = Votre méthode 'CreateObject'
            //TurnTable turntable = Votre méthode 'CreateObject'
            //Camera camera = Votre méthode 'CreateObject'

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
