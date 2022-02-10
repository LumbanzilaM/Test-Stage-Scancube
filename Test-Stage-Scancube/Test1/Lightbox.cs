using System;

/// <summary>
/// Summary description for Class1
/// </summary>

namespace Test_Stage_Scancube.Test1
{
	public class Lightbox
	{
		public uint Id { get; private set; }
		private static uint NextId = 0;

		public Lightbox()
		{
			this.Id = this.GenerateId();
		}
		public String GetInfo()
		{
			return "I'm a Lightbox";
		}

		private uint GenerateId()
		{
			return Lightbox.NextId++;
		}
	}
}
