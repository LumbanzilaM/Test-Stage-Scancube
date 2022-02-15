namespace Test_Stage_Scancube.Test1 {
    public class Camera : IHardware {
        string IHardware.GetInfo()
        {
            return "I'm a Camera";
        }
    }
}