using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CarteiraServices
/// </summary>
public class CarteiraServices : ICarteiraServices
{
    private readonly ICarteiraRepository _carteiraRepository;
    public CarteiraServices(ICarteiraRepository carteiraRepository)
    {
        _carteiraRepository = carteiraRepository;    
    }
    public bool CriarCarteira(Carteira carteira)
    {
        return _carteiraRepository.Inserir(carteira);
    }
    public Carteira BuscarCarteira(Carteira carteira)
    {
        var result = _carteiraRepository.Buscar(carteira);

        if (result.Count > 1)
            throw new ArgumentException("Existe mais de uma carteira as condições específicadas para a busca");
        else if (result.Count == 0)
            return null;

        return result[0];

    }
    public bool AtualizarCarteira(Carteira carteira) 
    {
        return _carteiraRepository.Sobrepor(carteira);
    }
    public Carteira AtualizarCarteira(Carteira de, Carteira para) 
    {
        return null;
    }
}