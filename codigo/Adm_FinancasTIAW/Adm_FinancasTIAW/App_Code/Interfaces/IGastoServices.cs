using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IGastoServices
/// </summary>
public interface IGastoServices 
{
     bool AdicionarGasto(Gasto gasto);
     List<Gasto> BuscarGastos(Gasto gasto);
}