namespace Visitor
{
	internal interface IVisitor
	{
		string VisitTextToHtmlConverter(TextToHtmlConverter component, string text);
		string VisitHtmlToTextConverter(HtmlToTextConverter component, string text);
	}
}