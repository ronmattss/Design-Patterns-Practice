namespace Design_Patterns_Practice.Design_Patterns.SOLID.Dependency_Inversion
{
    public class Task : ITask
    {
        public IPerson Owner { get; set; }
        private readonly IMessageSender _sender;
        public string TaskName { get; set; }
        public bool IsComplete { get; set; }
        public Task(IMessageSender sender)      // We create a dependency on the MessageSender class but using an interface meaning, we can swap out the MessageSender class for another implementation, without breaking the code
        {
            _sender = sender;
        }
        public void MarkComplete()
        {
            IsComplete = true;
            _sender.SendMessage("Task Completed by " + Owner.Name);
            
        }


    }
}