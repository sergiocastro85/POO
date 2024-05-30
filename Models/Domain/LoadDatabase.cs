using Microsoft.AspNetCore.Identity;

namespace AspNetCore.Models.Domain;

public class LoadDatabase
{
    public static async Task InsertarData(DatabaseContext context,
                                            UserManager<AplitaionUser> usuarioManager,
                                            RoleManager<IdentityRole> roleManager )
    {
        if (!roleManager.Roles.Any())
        {
            await roleManager.CreateAsync(new IdentityRole("ADMIN"));
        }

        if(!usuarioManager.Users.Any())
        {
            // crear objeto de tipo usuario

            var usuario=new AplitaionUser
            {
                Nombre="Sergio",
                Email="sergiocastro86@gmail.com",
                UserName="sergiocastro"
            };

            await usuarioManager.CreateAsync(usuario,"PaswordSergio123$");
            await usuarioManager.AddToRoleAsync(usuario,"ADMIN");

            if(!context.Categorias.Any())
            {
                context.Categorias!.AddRange(
                    new Categoria {Nombre="Drama"},
                    new Categoria {Nombre="Accion"},
                    new Categoria{Nombre="Filosofia"},
                    new Categoria{Nombre="Aventura"}

                );
            }

            if (!context.Libros.Any())
            {
                context.Libros!.AddRange(
                    new Libro 
                    {
                        Titulo ="Los cuatro acuerdos",
                        CreateDate="29/05/2024",
                        Imagen="Acuerdos.jpg",
                        Autor="Null"
                    },
                                        new Libro 
                    {
                        Titulo ="Meditaciones",
                        CreateDate="29/05/2024",
                        Imagen="Meditaciones.jpg",
                        Autor="Null"
                    }

                );
            }

            if (!context.LibroCategorias!.Any())
            {
                context.LibroCategorias!.AddRange(
                    new LibroCategoria
                    {
                        CategoriaId=1,
                        LibroId=1
                    },
                    new LibroCategoria
                    {
                        CategoriaId=1,
                        LibroId=2
                    }
                );

            }
            
            context.SaveChanges();


        }
    }
}