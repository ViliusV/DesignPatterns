using System.Collections.Generic;

namespace Bridge.Implementation
{
	public interface IDataService
	{
		List<string> GetData();
		void InsertData(string item);
	}
}
