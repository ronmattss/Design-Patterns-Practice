using System.Collections.Generic;

namespace Design_Patterns_Practice.Design_Patterns.SOLID.Liskov_Substitution
{
public class StaticData
{
    public static readonly List<string> Post = new List<string>();

    // check if post exists
    public static bool PostExists(int postId)
    {
        return Post.Count > postId;
    }
}
}
