using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for IMetaServices
/// </summary>
public interface IMetaServices
{
    bool AdicionarMeta(Meta meta);
    List<Meta> BuscarMetas(Meta meta);
    bool RemoverMeta(Meta meta);
}