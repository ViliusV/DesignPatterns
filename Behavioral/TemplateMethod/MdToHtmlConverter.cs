﻿namespace TemplateMethod
{

	internal class MdToHtmlConverter : AbstractTextToHtmlConverter
	{
		private readonly Dictionary<string, (string, string)> tagsToReplace;

		public MdToHtmlConverter()
		{
			tagsToReplace = new Dictionary<string, (string, string)>
			{
			  { "**", ("<strong>", "</strong>") },
			  { "*", ("<em>", "</em>") },
			  { "~~", ("<del>", "</del>") }
			};
		}
		protected override string ApplyPostProcessing(string text)
		{
			foreach (var key in tagsToReplace.Keys)
			{
				var replacementTags = tagsToReplace[key];
				if (CountStringOccurrences(text, key) % 2 == 0)
				{
					text = ApplyTagReplacement(text, key, replacementTags.Item1, replacementTags.Item2);
				}

			}

			return text;
		}
		private int CountStringOccurrences(string text, string pattern)
		{
			int count = 0;
			int currentIndex = 0;
			while ((currentIndex = text.IndexOf(pattern, currentIndex)) != -1)
			{
				currentIndex += pattern.Length;
				count++;
			}
			return count;
		}
		private string ApplyTagReplacement(string text, string inputTag, string outputOpeningTag, string outputClosingTag)
		{
			int count = 0;
			int currentIndex = 0;
			while ((currentIndex = text.IndexOf(inputTag, currentIndex)) != -1)
			{
				count++;
				if (count % 2 != 0)
				{
					var prepend = outputOpeningTag;
					text = text.Insert(currentIndex, prepend);
					currentIndex += prepend.Length + inputTag.Length;
				}
				else
				{
					var append = outputClosingTag;
					text = text.Insert(currentIndex, append);
					currentIndex += append.Length + inputTag.Length;
				}
			}
			return text.Replace(inputTag, string.Empty);
		}
	}
}
