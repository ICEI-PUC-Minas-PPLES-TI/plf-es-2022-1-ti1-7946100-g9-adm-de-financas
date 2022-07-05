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
}