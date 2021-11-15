using System.Collections.Generic;
using System.Linq;

namespace UserNameVisibility
{
    
    class Comment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public bool IsUserVisible { get; set; }

    }

    class CommentManager
    {
        List<Comment> Comments =new List<Comment>{};
        public void Add(Comment comment){
            Comments.Add(comment);
        }

        public Comment GetById(int id){
            return Comments.Find(x=>x.Id==id);
        }
        public List<Comment> GetByUserId(int userId){
            return Comments.Where(x=>x.UserId==userId).ToList();
        }
    }

}
