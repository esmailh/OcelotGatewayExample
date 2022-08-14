using UserAPI.Models;

namespace UserAPI.Data
{
    public static class DataModelGeneration
    {
        public static List<User> UserGenerate()
        {
            var output = new List<User>();
            for (int i = 0; i < 10; i++)
            {
                User User = new User();
                User.UserId = i;
                User.UserName = $"UserName{i}";
                User.Address = $"Address{i}";
               
                output.Add(User);
            }
            return output;
        }
    }
}
