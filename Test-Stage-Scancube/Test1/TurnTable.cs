namespace Test_Stage_Scancube.Test1 {
    public class TurnTable : IHardware {
        string IHardware.GetInfo()
        {
            return "I'm a Turntable";
        }
    }
}