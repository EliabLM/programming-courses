LinqQueries queries = new LinqQueries();

// Toda la colección
// ImprimirValores(queries.TodaLaColeccion());

// Libros despues del 2000
// ImprimirValores(queries.LibrosDespuesDel2000());

// Libros con más de 250 páginas y tienen en el titulo la palabra in Action
// ImprimirValores(queries.LibrosConMasDe250PagConPalabrasInAction());

// Todos los libros tienen Status
Console.WriteLine(queries.TodosLosLibrosTienenStatus());

void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach (var item in listadelibros)
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}
