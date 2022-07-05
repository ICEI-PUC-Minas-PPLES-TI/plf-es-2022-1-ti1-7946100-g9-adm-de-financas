using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TipoGasto
/// </summary>
public class TipoGasto
{
    [Key]
    public string Tipo { get; set; }
}