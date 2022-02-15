namespace Test_Stage_Scancube.Test2 {
    public class CCamera : Hardware
    {
        private static uint lastId = 0;

        public CCamera() : base(GenerateId())
        {}

        static uint GenerateId()
        {
            uint id = lastId;

            lastId++;
            return id;
        }
    }
}