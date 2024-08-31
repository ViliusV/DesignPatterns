namespace ChainOfResponsibility
{
	internal abstract class RequestHandler
    {
        protected RequestHandler successor;

        public abstract Response HandleRequest(Request request);

        public void SetNext(RequestHandler successor)
        {
            this.successor = successor;
        }
    }
}
