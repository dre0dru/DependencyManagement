namespace Dre0Dru.ComponentDependencies
{
    public interface IDependant<in TDependency>
    {
        void SetDependency(TDependency dependency);
    }
}
