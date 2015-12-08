using Newtonsoft.Json;
using Relink.DAL.Interface;
using Relink.Entities;
using System.Collections.Generic;
using System.IO;

namespace Relink.DAL.Textfile
{
	public class HardwareTextfile : IHardwareDAO
	{
		private string workFolderPath = InternalDAO.workFolderPath;

		private string processorDatFileName = InternalDAO.processorDatFileName;
		private string memoryDatFileName = InternalDAO.memoryDatFileName;
		private string modemDatFileName = InternalDAO.modemDatFileName;
		private string UserHWDatFileName = InternalDAO.UserHWDatFileName;
		
		private List<Hardware> allHardware { get; } = new List<Hardware>(16);
		private bool k = false;

		public List<Hardware> Load()
		{
			k = true;
			LoadProcessor(allHardware);
			LoadMemory(allHardware);
			LoadModem(allHardware);

			return LoadUserHW();
		}

		private List<Hardware> LoadUserHW()
		{
			List<Hardware> hwlist = new List<Hardware>(16);

			using (StreamReader fin = new StreamReader(
							new FileStream(
								Path.Combine(workFolderPath, UserHWDatFileName),
								FileMode.Open, FileAccess.Read)))
			{
				string str = fin.ReadLine();

				if (str == null)
				{
					return new List<Hardware>();
				}

                                return JsonConvert.DeserializeObject<List<Hardware>>(str);
			}
		}

		private void LoadProcessor(List<Hardware> allHardware)
		{
			using (StreamReader fin = new StreamReader(
							new FileStream(
								Path.Combine(workFolderPath, processorDatFileName),
								FileMode.Open, FileAccess.Read)))
			{
				string str = fin.ReadLine();
                                var a = JsonConvert.DeserializeObject<List<Hardware>>(str);
				foreach (var item in a)
				{
					allHardware.Add(item);
				}
			}
		}

		private void LoadMemory(List<Hardware> allHardware)
		{
			using (StreamReader fin = new StreamReader(
							new FileStream(
								Path.Combine(workFolderPath, memoryDatFileName),
								FileMode.Open, FileAccess.Read)))
			{
				var a = JsonConvert.DeserializeObject<List<Hardware>>(fin.ReadLine());
				foreach (var item in a)
				{
					allHardware.Add(item);
				}
			}
		}

		private void LoadModem(List<Hardware> allHardware)
		{
			using (StreamReader fin = new StreamReader(
							new FileStream(
								Path.Combine(workFolderPath, modemDatFileName),
								FileMode.Open, FileAccess.Read)))
			{
				var a = JsonConvert.DeserializeObject<List<Hardware>>(fin.ReadLine());
				foreach (var item in a)
				{
					allHardware.Add(item);
				}
			}
		}

		public void Save(List<Hardware> hardware)
		{
			SaveProcessor(hardware);
			SaveMemory(hardware);
			SaveModem(hardware);
		}

		private void SaveModem(List<Hardware> hardware)
		{
			using (StreamWriter fout = new StreamWriter(
							new FileStream(
								Path.Combine(workFolderPath, modemDatFileName),
								FileMode.Open, FileAccess.Write)))
			{
				fout.WriteLine(JsonConvert.SerializeObject(hardware));
			}
		}

		private void SaveMemory(List<Hardware> hardware)
		{
			using (StreamWriter fout = new StreamWriter(
							new FileStream(
								Path.Combine(workFolderPath, memoryDatFileName),
								FileMode.Open, FileAccess.Write)))
			{
				fout.WriteLine(JsonConvert.SerializeObject(hardware));
			}
		}

		private void SaveProcessor(List<Hardware> hardware)
		{
			using (StreamWriter fout = new StreamWriter(
							new FileStream(
								Path.Combine(workFolderPath, processorDatFileName),
								FileMode.Open, FileAccess.Write)))
			{
				fout.WriteLine(JsonConvert.SerializeObject(hardware));
			}
		}

		public List<Hardware> GetAllHardware()
		{
			List<Hardware> output = new List<Hardware>(this.allHardware.Count);

			for (int i = 0; i < this.allHardware.Count - 1; ++i)
			{
				output[i] = this.allHardware[i];
                        }
			return output;
                }
	}
}