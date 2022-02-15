namespace Test_Stage_Scancube.Test1 {
    public class Lightbox : IHardware {
        string IHardware.GetInfo()
        {
            return "I'm a Lightbox";
        }
    }
}