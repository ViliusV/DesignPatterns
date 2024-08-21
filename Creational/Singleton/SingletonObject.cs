using System;

namespace Singleton
{
	internal class SingletonObject
	{
		private static SingletonObject? instance;

		public int Data
		{
			get; private set;
		}

		private SingletonObject(int data)
		{
			Data = data;
		}

		public static SingletonObject GetInstance() {
			if (instance is null)
			{
				var random = new Random();
				instance = new SingletonObject(random.Next());
			}

			return instance;
		}
	}
}
