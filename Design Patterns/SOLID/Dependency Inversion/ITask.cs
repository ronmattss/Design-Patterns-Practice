namespace Design_Patterns_Practice.Design_Patterns.SOLID.Dependency_Inversion
{
    public interface ITask
    {
        IPerson Owner { get; set; }
        string TaskName { get; set; }
        
        bool IsComplete { get; set; }
        void MarkComplete();
        
    }
}