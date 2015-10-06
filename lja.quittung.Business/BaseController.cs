namespace lja.quittung.Business
{
    public abstract class BaseController<T>
    {
        public readonly T View;

        protected BaseController(T view)
        {
            View = view;
        }

        public abstract void SubscribeEvents();

        public abstract void UnsubscribeEvents();
    }
}
