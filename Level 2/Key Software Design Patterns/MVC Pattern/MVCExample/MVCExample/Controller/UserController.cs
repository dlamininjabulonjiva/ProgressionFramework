using MVCExample.Model;
using MVCExample.View;

namespace MVCExample.Controller
{
    public class UserController
    {
        private readonly User _user;
        private readonly UserView _userView;

        public UserController(User user, UserView userView)
        {
            _user = user;
            _userView = userView;
        }

        public void UpdateUserDetails(int id, string name, string email)
        {
            _user.Id = id;
            _user.Name = name;
            _user.Email = email;
        }

        public void PrintUserDetails()
        {
            _userView.PrintUserDetails(_user.Id, _user.Name, _user.Email);
        }
    }
}
