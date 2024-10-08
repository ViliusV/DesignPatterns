﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proxy
{
	internal class DataService : IDataService
    {
        private readonly List<string> data;
        public DataService()
        {
            data = new();
        }
        public async Task<List<string>> GetData()
        {
            // Simulate long-running process
            await Task.Delay(3000);
            return data;
        }
        public void InsertData(string item)
        {
            data.Add(item);
        }
    }
}
