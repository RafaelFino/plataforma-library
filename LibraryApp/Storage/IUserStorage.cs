using LibraryApp.Domains;

namespace LibraryApp.Storage
{
    public interface IUserStorage
    {
        IEnumerable<User> GetUsers();
        User GetUser(int id);
        bool CreateUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int id);
    }
}
