namespace Backup
{
	public class Hdd:Storage
	{
		public int Speed { get; set; }
		public int Memory { get; set; }

		public Hdd(string name,string model,int speed, int memory) : base(name, model)
		{
			Speed = speed;
			Memory = memory;
		}

		public override int GetCapacity()
		{
			return Memory;
		}

		public override int Copy(int fileSize)
		{
			int totalMedia = 0;
			while (fileSize > 0)
			{
				fileSize -= Memory;
				totalMedia++;
			}
			return totalMedia; ;
		}
		public override int FreeMemory(int fileSize)
		{
			int usedMemory = fileSize % Memory;
			return usedMemory == 0 ? 0 : Memory - usedMemory;
		}
		public override void PrintDeviceInfo()
		{
			Console.WriteLine($"HDD: {Name}, Model: {Model}, Tutumu: {Memory} GB, Suret: {Speed} MB/s");
		}
	}
}
