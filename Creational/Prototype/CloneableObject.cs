using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
	internal class CloneableObject : ICloneable
	{
		private readonly int internalData;
		private readonly string internalTitle;

		public CloneableObject(string title)
		{
			var random = new Random(); 
			internalData = random.Next();
			
			internalTitle = title;
		}

		public int Data => internalData;
		public string Title => internalTitle;
		public ICloneable Clone()
		{
			return (CloneableObject)MemberwiseClone();
		}
	}
}
