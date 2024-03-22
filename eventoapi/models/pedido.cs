using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace api.Models;
public class pedido
{
    [Column("id_pedido")]
    public int Id_pedido { get; set; } 

    [Column("data")]

    public DateTime data {get; set;}

    [Column("total")]

    public double total{get; set;}

    [Column("quantidade")]

    public int quantidade{get;set;}

    [Column("forma_pagamento")]
    
    public string forma_pagamento{get;set;}

    [Column("status")]

    public string status{get;set;}

}