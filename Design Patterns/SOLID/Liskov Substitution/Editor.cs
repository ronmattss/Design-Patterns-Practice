namespace Design_Patterns_Practice.Design_Patterns.SOLID.Liskov_Substitution
{
    public class Editor : Role, IEditPost
    {
        public Editor(string pageRole) : base(pageRole)
        {
        }

        public void EditPost(int postId, string post)
        {
            StaticData.Post[postId] = post;
            System.Console.WriteLine("Edited post by Admin");
            System.Console.WriteLine(StaticData.Post[postId]);

        }

        public override void DisplayPost(int postId)
        {
            if (!StaticData.PostExists(postId)) return;
            base.DisplayPost(postId);
            System.Console.WriteLine("Edited post");
        }
    }
}