using Abnoan.MVC;
public static class Program
{
    static void Main(string[] args)
    {
        UserModel model = new UserModel();
        UserView view = new UserView();
        UserController controller = new UserController(model, view);

        // Simulação de entrada do usuário
        Console.WriteLine("Por favor, digite seu nome:");
        string userName = Console.ReadLine();

        // Configuração e atualização da View
        controller.SetUserName(userName);
    }
}