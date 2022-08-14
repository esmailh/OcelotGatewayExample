using Microsoft.AspNetCore.Mvc;
using UserAPI.Data;
using UserAPI.Models;
namespace UserAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private List<User> Users;
        public UserController()
        {
            Users = DataModelGeneration.UserGenerate();
        }
        [HttpGet]
        public IEnumerable<User> UserList()
        {
            var UserList = Users;
            return UserList;
        }
        [HttpGet("{id}")]
        public User GetUserById(int id)
        {
            return Users.SingleOrDefault(x => x.UserId == id, new User());
        }
        [HttpPost]
        public User AddUser(User User)
        {
            Users.Add(User);
            return User;
        }
        [HttpPut]
        public User UpdateUser(User User)
        {
            var prod = Users.SingleOrDefault(x => x.UserId == User.UserId);
            Users.Remove(prod);
            Users.Add(User);
            return User;
        }
        [HttpDelete("{id}")]
        public bool DeleteUser(int id)
        {
            var User = Users.SingleOrDefault(p => p.UserId == id);
            Users.Remove(User);
            return true;
        }
    }
}