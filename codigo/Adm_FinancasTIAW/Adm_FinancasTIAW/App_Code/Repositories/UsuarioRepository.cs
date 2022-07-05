using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for UsuarioRepository
/// </summary>
public class UsuarioRepository : IUsuarioRepository
{
    public bool Inserir(Usuario usuario) 
    {
        return HoskeORM.Insert(usuario);
    }
    public bool Deletar(Usuario usuario)
    {
        return HoskeORM.Delete(usuario);
    }
    public bool Atualizar(Usuario de, Usuario para)
    {
        return true;
        //return ORM.Update(de,para);
    }
    public bool Sobrepor(Usuario usuario)
    {

        return HoskeORM.Replace(usuario);
    }
    public List<Usuario> Buscar(Usuario usuario)
    {
        return HoskeORM.Select<Usuario>(usuario);
    }
}