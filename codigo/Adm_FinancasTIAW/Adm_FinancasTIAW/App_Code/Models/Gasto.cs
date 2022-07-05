using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Gasto
/// </summary>
public class Gasto
{
    [AutoIncrement]
    [Key]
    public int? Id { get; set; } = null;
    public decimal? Valor { get; set; } = null;
    public TipoGasto Tipo { get; set; }
    public Carteira Carteira { get; set; }
}