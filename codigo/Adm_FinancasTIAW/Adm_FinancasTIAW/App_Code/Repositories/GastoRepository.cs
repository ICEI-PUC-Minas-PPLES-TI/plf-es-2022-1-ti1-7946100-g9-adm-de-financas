using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GastoRepository
/// </summary>
public class GastoRepository : IGastoRepository
{
    public bool Inserir(Gasto gasto)
    {
        return HoskeORM.Insert(gasto);
    }
    public bool Deletar(Gasto gasto)
    {
        return HoskeORM.Delete(gasto);
    }
    public bool Atualizar(Gasto de, Gasto para)
    {
        return true;
        //return ORM.Update(de, para);
    }
    public bool Sobrepor(Gasto gasto)
    {

        return HoskeORM.Replace(gasto);
    }
    public List<Gasto> Buscar(Gasto gasto)
    {
        return HoskeORM.Select<Gasto>(gasto);
    }
}