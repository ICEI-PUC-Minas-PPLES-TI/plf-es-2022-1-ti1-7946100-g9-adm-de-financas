using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
/// <summary>
/// Summary description for IUsuario
/// </summary>
public interface IUsuarioServices
{
    bool CadastrarUsuario(string email, string nome, string senha, bool criarCarteira = true);
    Usuario LogarUsuario(string email, string senha);
    Usuario BuscarUsuario(Usuario usuario);
}