namespace Design_Patterns_Practice.Design_Patterns.SOLID.Liskov_Substitution
{
    public class Admin : Role, IEditPost, IMakePost
    {
        public Admin(string pageRole) : base(pageRole)
        {
        }

       public void EditPost(int postId, string post)
        {
            StaticData.Post[postId] = post;
            System.Console.WriteLine("Edited post by Admin");
            System.Console.WriteLine(StaticData.Post[postId]);
        }

        public void MakePost(string post)
        {
            StaticData.Post.Add(post);
            System.Console.WriteLine("Made post");
            System.Console.WriteLine(StaticData.Post[StaticData.Post.Count - 1]);
        }

       public override void DisplayPost(int postId)
        {
            if (!StaticData.PostExists(postId)) return;
            base.DisplayPost(postId);
            System.Console.WriteLine("Admin Viewed post");
        }
    }
}