using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Carteira
/// </summary>
public class Carteira
{
    [AutoIncrement]
    [Key]
    public int? Id { get; set; } = null;
    public Usuario Usuario { get; set; }
    public decimal? Saldo { get; set; } = null;
    public decimal? GanhoMensal { get; set; } = null;
}