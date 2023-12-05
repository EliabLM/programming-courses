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
// ImprimirValores(queries.TresPrimerosLibros());

// Cantidad de libros que tienen entre 200 y 500 páginas
// Console.WriteLine($"Cantidad de libros que tienen entre 200 y 500 pag. {queries.CantidadDeLibrosEntre200Y500Pag()}");

// Fecha de publicación menor
// Console.WriteLine($"Fecha de publicación menor: {queries.FechaDePublicacionMenor()}");

// Número de páginas del libro con mayor número de páginas
// Console.WriteLine($"El libro con mayor número de páginas tiene: {queries.NumeroDePagLibroMayor()}");

// Libro con menor número de páginas
// var libroMenorPag = queries.LibroConMenorNumeroDePag();
// Console.WriteLine($"{libroMenorPag.Title} - {libroMenorPag.PageCount}");

// Libro con fecha de publicación más reciente
// var libroFechaPubReciente = queries.LibroConMenorNumeroDePag();
// Console.WriteLine($"{libroFechaPubReciente.Title} - {libroFechaPubReciente.PublishedDate.ToShortDateString()}");

// Suma de páginas de libros entre 0 y 500 páginas
// Console.WriteLine($"Suma total de páginas: {queries.SumaDeTodasLasPaginasLibrosEntre0y500()}");

// Libros publicados después de 2015
// Console.WriteLine(queries.TitulosDeLibrosDespuesDel2015Concatenados());

// Promedio de caracteres del titulo de los libros
// Console.WriteLine($"Promedio caracteres de los titulos: {queries.PromedioCaracteresTitulo()}");

// Libros publicados a partir del 2000 agrupados por año
// ImprimirGrupo(queries.LibrosDespuesDel2000AgrupadosPorAno());

// Diccionario de libros agrupados por primera letra del título
// ImprimirDiccionario(queries.DiccionarioDeLibrosPorLetra(), 'P');

// Libros filtrados con la clausula join
ImprimirValores(queries.LibrosDespuesDel2005ConMasDe500Pags());


void ImprimirValores(IEnumerable<Book> listadelibros)
{
    Console.WriteLine("{0,-60} {1, 15} {2, 15}\n", "Titulo", "N. Paginas", "Fecha publicacion");
    foreach (var item in listadelibros)
    {
        Console.WriteLine("{0,-60} {1, 15} {2, 15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}

void ImprimirGrupo(IEnumerable<IGrouping<int, Book>> ListaDeLibros)
{
    foreach (var grupo in ListaDeLibros)
    {
        Console.WriteLine("");
        Console.WriteLine($"Grupo: {grupo.Key}");
        Console.WriteLine("{0, -60} {1, 15} {2, 15}\n", "Titulo", "N. Páginas", "Fecha publicación");
        foreach (var item in grupo)
        {
            Console.WriteLine("{0, -60} {1, 15} {2,15}", item.Title, item.PageCount, item.PublishedDate.Date);
        }
    }
}

void ImprimirDiccionario(ILookup<char, Book> ListaDeLibros, char letra)
{
    Console.WriteLine("{0, -60} {1, 15} {2, 15}\n", "Titulo", "N. Páginas", "Fecha publicación");
    foreach (var item in ListaDeLibros[letra])
    {
        Console.WriteLine("{0, -60} {1, 15} {2,15}", item.Title, item.PageCount, item.PublishedDate.ToShortDateString());
    }
}
