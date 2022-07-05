using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Meta
/// </summary>
public class Meta
{
    [AutoIncrement]
    [Key]
    public int? Id { get; set; } = null;
    public string Descricao { get; set; }
    public decimal? Valor { get; set; } = null;
    public DateTime DataFim { get; set; }
    public Usuario Usuario { get; set; }
}