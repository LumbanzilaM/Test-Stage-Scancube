namespace Test_Stage_Scancube.Test2
{
    public class CTurnTable : Hardware
    {
        private static uint lastId = 0;

        public CTurnTable() : base(GenerateId())
        {}

        static uint GenerateId()
        {
            uint id = lastId;

            lastId++;
            return id;
        }
    }
}