using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Abnoan.MVC
{
    // Model: Define a lógica de negócios e manipula dados
    public class UserModel
    {
        public string Name { get; set; }
        public string GetWelcomeMessage()
        {
            return $"Bem-vindo ao nosso sistema, {Name}!";
        }
    }
}