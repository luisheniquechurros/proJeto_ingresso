using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;

namespace api.Models;
public class Personagem
{
    [Column("id_usuario")]
    public int Id_usuario { get; set; } 

    [Column("nome_completo")]

    public string nome_completo {get; set;}

    [Column("email")]

    public string email{get; set;}

    [Column("senha")]

    public string senha{get;set;}

    [Column("telefone")]
    
    public string telefone{get;set;}

    [Column("perfil")]

    public string perfil{get;set;}

    [Column("status")]

    public string status{get;set;}
}