using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proxy
{
	internal interface IDataService
	{
		Task<List<string>> GetData();
		void InsertData(string item);
	}
}
