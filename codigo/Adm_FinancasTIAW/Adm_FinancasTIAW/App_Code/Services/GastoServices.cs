using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for GastoServices
/// </summary>
public class GastoServices : IGastoServices
{
    private readonly IGastoRepository _gastoRepository;
    public GastoServices(IGastoRepository gastoRepository)
    {
        _gastoRepository = gastoRepository;
    }
    public bool AdicionarGasto(Gasto gasto)
    {
        return _gastoRepository.Inserir(gasto);
    }
    public List<Gasto> BuscarGastos(Gasto gasto)
    {
        var result = _gastoRepository.Buscar(gasto);
        if (result.Count == 0)
            return null;

        return result;

    }
}