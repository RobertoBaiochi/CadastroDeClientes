using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaLoja.Login
{
    static class UsuarioLogin
    {
        private static Usuario[] usuarios =
        {
            new Usuario() {Nome = "admin", Senha = "admin" },
            new Usuario() { Nome = "Fernando", Senha = "123qwe"},
            new Usuario() { Nome = "Carla", Senha = "098poi"}
        };

        private static Usuario _usuarioLogado = null;

        public static Usuario UsuarioLogado
        {
            get { return _usuarioLogado; }
            private set { _usuarioLogado = value; }
        }

        public static bool FazerLogin(string username, string password)
        {
            foreach (Usuario usuario in usuarios)
            {
                if (usuario.Nome == username && usuario.Senha == password)
                {
                    UsuarioLogado = usuario;
                    return true;
                }
            }

            return false;
        }
    }
}
