namespace Facade_Pattern
{
    public class Facade
    {
        public void ExecuteOneSystem()
        {
            new SubsystemA().Execute();
        }

        public void ExecuteOtherSystem() => new SubsystemB().Execute();        
    }
}