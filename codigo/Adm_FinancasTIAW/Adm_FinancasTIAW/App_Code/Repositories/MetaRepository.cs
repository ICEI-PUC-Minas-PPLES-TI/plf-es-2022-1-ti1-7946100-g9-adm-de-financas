using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MetaRepository
/// </summary>
public class MetaRepository : IMetaRepository
{
    public bool Inserir(Meta meta)
    {
        return HoskeORM.Insert(meta);
    }
    public bool Deletar(Meta meta)
    {
        return HoskeORM.Delete(meta);
    }
    public bool Atualizar(Meta de, Meta para)
    {
        return true;
        //return ORM.Update(de, para);
    }
    public bool Sobrepor(Meta meta)
    {

        return HoskeORM.Replace(meta);
    }
    public List<Meta> Buscar(Meta meta)
    {
        return HoskeORM.Select<Meta>(meta);
    }
}