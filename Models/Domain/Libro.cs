using System.ComponentModel.DataAnnotations;

namespace AspNetCore.Models.Domain;

public class Libro
{
    [Key]
    [Required]
    // lon que tengo encima son las notaciones
    public int  Id { get; set; }

    public string? Titulo { get; set; }

    public string? CreateDate { get; set; }

    public string? Imagen { get; set; }

    [Required]
    public string? Autor { get; set; }


    //crear la colección categorias
    public virtual ICollection<Categoria>? CategoriaRelationList { get; set; }

    //crear la coleccion libro Categoria
    public virtual ICollection<LibroCategoria>? LibroCategoriaRelationList{ get; set; }


}