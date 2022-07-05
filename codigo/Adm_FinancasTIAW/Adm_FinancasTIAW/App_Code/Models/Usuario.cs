using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
/// <summary>
/// Summary description for Usuario
/// </summary>
public class Usuario
{
    [AutoIncrement]
    [Key]
    public int? Id { get; set; } = null;
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }

}