using System;

namespace Design_Patterns_Practice.Design_Patterns.SOLID.Liskov_Substitution
{
public abstract class Role : IPageRole, IViewPost
{
    protected Role(string pageRole)
    {
        PageRole = pageRole;
    }
    
    public string PageRole { get; set; }
    

    public virtual void DisplayPost(int postId)
    {        
        if(!StaticData.PostExists(postId)) return;
        Console.WriteLine(StaticData.Post[postId]);
    }
}
}