﻿using Bridge.Implementation;
using System;

namespace Bridge.Interface
{
	internal class BridgeInterface
    {
		public IDataService? Implementation { get; set; }

        public void GetData()
        {
            if (Implementation is null)
            {
                Console.WriteLine("No data.");
                return;
            }
            foreach (var item in Implementation.GetData())
            {
                Console.WriteLine(item);
            }
        }

        public void InsertData(string item)
        {
            Implementation?.InsertData(item);
        }
    }
}
