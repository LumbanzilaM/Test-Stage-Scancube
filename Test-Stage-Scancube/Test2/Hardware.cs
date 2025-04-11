using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Stage_Scancube.Test2
{
    public static class Hardware
    {
        private static Random rnd { get; set; } = new Random();
        public static List<int> Ids { get; set; } = new List<int>();
        public static int GenerateId()
        {
            int id = rnd.Next(1, 100000);
            if (Ids.Find(x => x == id) != 0)
            {
                return GenerateId();
            }
            else
            {
                Ids.Add(id);
                return id;
            }
        }
    }

    public class Lightbox
    {
        public Lightbox() 
        {
            Id = Hardware.GenerateId();
        }
        public string GetInfo()
        {
            return "I'm a Lightbox";
        }
        public int Id { get; set; }
    }
    public class TurnTable
    {
        public TurnTable() 
        {
            Id = Hardware.GenerateId();
        }
        public string GetInfo()
        {
            return "I'm a Turntable";
        }
        public int Id { get; set; }
    }
    public class Camera
    {
        public Camera() 
        {
            Id = Hardware.GenerateId();
        }
        public string GetInfo()
        {
            return "I'm a Camera";
        }
        public int Id { get; set; }
    }
}
