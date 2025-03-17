namespace Core
{
    public interface INameDebugger
    {
        public virtual string GetStateName()
        {
            return GetType().Name;
        }
    }
}