namespace Design_Patterns_Practice.Design_Patterns.SOLID.Liskov_Substitution
{
    public class Viewer : Role
    {
        public Viewer(string pageRole) : base(pageRole)
        {
        }

        public override void DisplayPost(int postId)
        {
            if (!Design_Patterns_Practice.Design_Patterns.SOLID.Liskov_Substitution.StaticData.PostExists(postId))
            {
                System.Console.WriteLine("Post does not exist");
            }
            base.DisplayPost(postId);
            System.Console.WriteLine("Viewer viewed post");
        }
    }
}