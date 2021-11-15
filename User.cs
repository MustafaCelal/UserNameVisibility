using System.Collections.Generic;

namespace UserNameVisibility
{
    
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }

    class UserManager
    {
        List<User> Users =new List<User>{};
        public void Add(User User){
            Users.Add(User);
        }
        public User GetById(int id){
            return Users.Find(x=>x.Id==id);
        }
        public List<User> GetAll(){
            return Users;
        }
    }
}
