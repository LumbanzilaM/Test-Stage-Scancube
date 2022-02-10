using System;

/// <summary>
/// Summary description for Class1
/// </summary>

namespace Test_Stage_Scancube.Test1
{
	public class TurnTable
	{
		public uint Id { get; private set; }
		private static uint NextId = 0;

		public TurnTable()
		{
			this.Id = this.GenerateId();
		}
		public String GetInfo()
		{
			return "I'm a Turntable";
		}
		
		private uint GenerateId()
        {
			return TurnTable.NextId++;
        }
	}
}
