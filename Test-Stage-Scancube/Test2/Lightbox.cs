namespace Test_Stage_Scancube.Test2
{
    public class CLightbox : Hardware
    {
        private static uint lastId = 0;

        public CLightbox() : base(GenerateId())
        {}

        static uint GenerateId()
        {
            uint id = lastId;

            lastId++;
            return id;
        }
    }
}