﻿using System.Collections.Generic;

namespace Bridge.Implementation
{
	public class DataService : IDataService
	{
		private readonly List<string> data;
		public DataService()
		{
			data = new();
		}
		public List<string> GetData()
		{
			return data;
		}
		public void InsertData(string item)
		{
			data.Add(item);
		}
	}
}
