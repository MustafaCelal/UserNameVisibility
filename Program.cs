using System;

namespace UserNameVisibility
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager=new UserManager();

            userManager.Add(new User{Id=1,Name="John",Surname="Doe"});
           
            //Console.WriteLine(userManager.GetById(1).Name);

            CommentManager commentManager=new CommentManager();

            commentManager.Add(new Comment{Id=1,Content="content 1", UserId=1,Title="title 1",IsUserVisible=true});
            commentManager.Add(new Comment{Id=2,Content="content 2", UserId=1,Title="title 2",IsUserVisible=false});

            var comments=commentManager.GetByUserId(1);

            foreach(var comment in comments)
            {
                var user=userManager.GetById(comment.UserId);
                
                Console.WriteLine($"\n-{comment.Title}-\n\t{comment.Content}\n");
                
                if(!comment.IsUserVisible)
                    Console.WriteLine($"{user.Name[0]}*** {user.Surname[0]}***");
                else
                    Console.WriteLine($"{user.Name} {user.Surname}");
                
                Console.WriteLine("___\n");
                
            }
            
        }
    }
}
