using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ICarteiraServices
/// </summary>
public interface ICarteiraServices
{
    bool CriarCarteira(Carteira carteira);

    Carteira BuscarCarteira(Carteira carteira);
}