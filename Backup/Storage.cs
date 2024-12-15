namespace Backup
{
	abstract public class Storage
	{
		
		public string Name { get; set; }
		public string Model { get; set; }
		public abstract int FreeMemory(int fileSize);
		protected Storage(string name, string model)
		{
			Name = name;
			Model = model;
		}

		public abstract int GetCapacity();
		public abstract int Copy(int fileSize);
		public abstract void PrintDeviceInfo();
	}
}
