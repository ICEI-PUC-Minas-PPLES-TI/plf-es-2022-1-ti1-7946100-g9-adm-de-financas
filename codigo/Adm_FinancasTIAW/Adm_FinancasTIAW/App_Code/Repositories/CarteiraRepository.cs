using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CarteiraRepository
/// </summary>
public class CarteiraRepository : ICarteiraRepository
{
    public bool Inserir(Carteira carteira)
    {
        return HoskeORM.Insert(carteira);
    }
    public bool Deletar(Carteira carteira)
    {
        return HoskeORM.Delete(carteira);
    }
    public bool Atualizar(Carteira de, Carteira para)
    {
        return true;
        //return ORM.Update(de, para);
    }
    public bool Sobrepor(Carteira carteira)
    {

        return HoskeORM.Replace(carteira);
    }
    public List<Carteira> Buscar(Carteira carteira)
    {
        return HoskeORM.Select<Carteira>(carteira);
    }
}