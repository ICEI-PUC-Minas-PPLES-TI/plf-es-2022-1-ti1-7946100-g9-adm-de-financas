using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for MetaServices
/// </summary>
public class MetaServices : IMetaServices
{
    private IMetaRepository _metaRepository;
    public MetaServices(IMetaRepository metaRepository)
    {
        _metaRepository = metaRepository;
    }
    public bool AdicionarMeta(Meta meta) 
    {
        return _metaRepository.Inserir(meta);
    }
    public List<Meta> BuscarMetas(Meta meta) 
    {
        return _metaRepository.Buscar(meta);
    }
    public bool RemoverMeta(Meta meta)
    {
        return _metaRepository.Deletar(meta);
    }
}