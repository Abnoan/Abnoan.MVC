using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.MVC
{
    // Controller: Intermedia a comunicação entre Model e View
    public class UserController
    {
        private UserModel _model;
        private UserView _view;

        public UserController(UserModel model, UserView view)
        {
            _model = model;
            _view = view;
        }

        public void UpdateView()
        {
            string message = _model.GetWelcomeMessage();
            _view.DisplayMessage(message);
        }

        public void SetUserName(string name)
        {
            _model.Name = name;
            UpdateView();
        }
    }
}