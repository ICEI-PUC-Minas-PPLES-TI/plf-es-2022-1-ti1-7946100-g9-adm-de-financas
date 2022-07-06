using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UsuarioServices
/// </summary>
public class UsuarioServices : IUsuarioServices
{
    private readonly IUsuarioRepository _usuarioRepository;
    private readonly ICarteiraServices _carteiraServices;
    public UsuarioServices(IUsuarioRepository usuarioRepository, ICarteiraServices carteiraServices)
    {
        _usuarioRepository = usuarioRepository;
        _carteiraServices = carteiraServices;
    }
   
    public bool CadastrarUsuario(string email, string nome, string senha, bool criarCarteira = true)
    {
        var usuario = new Usuario()
        {
            Email = email,
        };
        if (this.BuscarUsuario(usuario) == null)
        {
            usuario.Nome = nome;
            usuario.Senha = senha;
            this.CriarUsuario(usuario);
            if(criarCarteira)
                _carteiraServices.CriarCarteira(new Carteira()
                {
                    GanhoMensal = 0,
                    Saldo = 0,
                    Usuario = usuario
                });
            return true;
        }
        else
        {
            throw new ArgumentException("Já existe um usuário cadastrado com este email!");
        }
    }
    public Usuario BuscarUsuario(Usuario usuario)
    {
        var result = _usuarioRepository.Buscar(usuario);

        if (result.Count > 1)
            throw new ArgumentException("Existe mais de um usuário com as condições específicadas para a busca");
        else if (result.Count == 0)
            return null;

        return result[0];

    }
    public Usuario LogarUsuario(string email, string senha) 
    {

        var usuario = BuscarUsuario(new Usuario() {Email = email, Senha = senha });
        return usuario;
    }

    #region Métodos privados
    private bool CriarUsuario(Usuario usuario)
    {
        return _usuarioRepository.Inserir(usuario);
    }

    #endregion
}