using System;

/// <summary>
/// Summary description for Class1
/// </summary>

namespace Test_Stage_Scancube.Test1
{
	public class Camera
	{
		public uint Id { get; private set; }
		private static uint NextId = 0;

		public Camera()
		{
			this.Id = this.GenerateId();
		}
		public String GetInfo()
		{
			return "I'm a Camera";
		}

		private uint GenerateId()
		{
			return Camera.NextId++;
		}
	}
}
