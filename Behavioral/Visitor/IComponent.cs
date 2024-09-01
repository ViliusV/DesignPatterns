namespace Visitor
{
	internal interface IComponent
	{
		string Accept(IVisitor visitor, string text);
	}
}
