namespace TemplateMethod
{
	internal class BasicTextToHtmlConverter : AbstractTextToHtmlConverter
	{
		protected override string ApplyPostProcessing(string text)
		{
			return text;
		}
	}
}
