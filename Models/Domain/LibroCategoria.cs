namespace AspNetCore.Models.Domain;

public class LibroCategoria
{
    
    public int Id { get; set; }

    public int CategoriaId { get; set; }

    //referenciar las claves foreneas (CategoriaId)
    public Categoria? categoria{ get; set; }
    public int LibroId { get; set; }

    //referenciar las claves foreneas (LibroId)
    public Libro? libro {get; set;}


}