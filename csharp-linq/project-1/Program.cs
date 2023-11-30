LinqQueries queries = new LinqQueries();

// Toda la colección
// ImprimirValores(queries.TodaLaColeccion());

// Libros despues del 2000
// ImprimirValores(queries.LibrosDespuesDel2000());

// Libros con más de 250 páginas y tienen en el titulo la palabra in Action
// ImprimirValores(queries.LibrosConMasDe250PagConPalabrasInAction());

// Todos los libros tienen Status
// Console.WriteLine(queries.TodosLosLibrosTienenStatus());

// Algún libro fue publicado en 2005
// Console.WriteLine(queries.SiAlgunLibroFuePublicado2005());

// Libros de Python
// ImprimirValores(queries.LibrosDePython());

// Libros de Java ordenados por nombre ascendente
// ImprimirValores(queries.LibrosDeJavaPorNombreAscendente());

// Libros de mas de 450 páginas ordenados descendente
// ImprimirValores(queries.LibrosMasDe450PaginasDescendente());

// 3 primeros libros de Java mas recientes
// ImprimirValores(queries.TresLibrosDeJavaMasRecientes());

// Tercer y cuarto libros con más de 400 páginas
// ImprimirValores(queries.TercerYCuartoLibroDeMas400Pag());

// Tres primeros libros filtrados con Select
ImprimirValores(queries.TresPrimerosLibros());

void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach (var item in listadelibros)
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}
