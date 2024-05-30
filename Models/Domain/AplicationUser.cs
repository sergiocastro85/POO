using Microsoft.AspNetCore.Identity;

namespace AspNetCore.Models.Domain;


//clase que representa a mis usuarios de la app
public class AplitaionUser : IdentityUser
{
    public string? Nombre { get; set; }

}