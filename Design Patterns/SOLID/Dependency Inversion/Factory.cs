namespace Design_Patterns_Practice.Design_Patterns.SOLID.Dependency_Inversion
{
    public static class Factory
    {
        // Factory Method
        // Create Person Class

        public static IPerson CreatePerson()
        {
            return new Person();
        }
        
        public static ITask CreateTask()
        {
            return new Task(CreateMessageSender());
        }
        
        public static IMessageSender CreateMessageSender()
        {
            return new EmailSender();
        }
    }
}