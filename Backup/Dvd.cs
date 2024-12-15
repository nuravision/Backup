

namespace Backup
{
	public class Dvd:Storage
	{
		public int Speed { get; set; }
		public string Type { get; set; }
		public int Memory { get; set; }
		public Dvd(string name,string model,int speed, string type, int memory):base(name,model)
		{
			Speed = speed;
			Type = type;
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
			return totalMedia;
		}

		public override int FreeMemory(int fileSize)
		{
			int usedMemory = fileSize % Memory;
			return usedMemory == 0 ? 0 : Memory - usedMemory;
		}
		public override void PrintDeviceInfo()
		{
			Console.WriteLine($"DVD: {Name}, Model: {Model}, Tutumu: {Memory} GB, Tipi: {Type}, Suret: {Speed} MB/s");
		}
	}
}
