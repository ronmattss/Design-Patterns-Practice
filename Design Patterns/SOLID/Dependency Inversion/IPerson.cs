namespace Design_Patterns_Practice.Design_Patterns.SOLID.Dependency_Inversion
{
    public interface IPerson
    {
        string Name { get; set; }
        int Age { get; set; }
        void Work();
    }
}