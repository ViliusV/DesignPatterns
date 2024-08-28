namespace Composite
{
	internal interface IComponent
    {
        string Name
        {
            get;
        }

        void Display(string currentPath);
    }
}
