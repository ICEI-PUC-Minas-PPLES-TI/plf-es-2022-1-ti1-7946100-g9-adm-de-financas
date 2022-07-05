using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Repository
/// </summary>
public interface IRepository<T>
{
     bool Inserir(T item);
     bool Sobrepor(T item);
     bool Deletar(T item);
     bool Atualizar(T de, T para);
     List<T> Buscar(T item);
}