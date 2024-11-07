//Trabajar con archivos.



//Clase File y la clase FileInfo (File es estática y FileInfo es específica de un fichero en concreto,
//por lo que se crea una instancia para ese fichero, se utiliza cuando vamos a realizar varias acciones con ese fichero)


//Leerlo. 

string ruta = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "hola.txt";
//Devuelve string con todo el contenido delf fichero 
var contenido = File.ReadAllText(ruta);
Console.WriteLine(contenido);


//Devuelve un array de strings, donde cada string es una línea. 
//Si el archivo tiene varias líneas y queremos tener un arrays de strings, donde cada elemento sea una línea. 

var lineas= File.ReadAllLines(ruta);


//Comprobar que exista 
//Si nos equivocamos en la ruta del archivo nos muestra error FileNotFoundException

if ( File.Exists(ruta)
{
    Console.WriteLine("Existe");
}

//Copiar un archivo de una ruta a otra 


var rutaDestino = @"C:\Users\Silvia\Documents\hola.txt"; 

File.Copy(ruta, rutaDestino);

//Si el archivo ya existe, nos manda una excepción, si lo que queremos es que sobreescriba

File.Copy (ruta, rutaDestino, overwrite:true);


//Borrar el archivo

File.Delete(rutaDestino);

//Clase Directory o DirectoryInfo
//Nos va a permitir trabajar con directorios. 

//Crear un directorio
var rutaDir = Environment.CurrentDirectory;

Directory.CreateDirectory(rutaDir);

//Se puede crear varios directorios a la vez… todos aquella estructura del arbol que se le pase en la ruta

//Podemos mostrar los directorios 

var rutas = Directory.EnumerateDirectories(rutaDir);

//Podemos mostrar los subdirectorios tb 
 var rutas2 = Directory.EnumerateDirectories(ruta, "*", SearchOption.AllDirectories);


//Podemos mostrar los ficheros
var rutas3 = Directory.EnumerateFiles(ruta, "*", SearchOption.AllDirectories);

//Si queremos filtrar por algún tipo de ficheros.  
var rutas4 = Directory.EnumerateFiles(ruta, "*.json", SearchOption.AllDirectories);


//Si queremos borrar un directorio

Directory.Delete(rutaDir);



//Clase Path

//Obtener el nombre del archivo de una ruta

var nombreArchivo = Path.GetFileName(ruta);

//Para obtener las extesiones:

var extension = Path.GetExtension(ruta);

//Combinar rutas 

var rutaCombinada= Path.Combine(ruta, rutaDestino);



//Streams

//Es una abstracción de una secuencia de bytes.  Leer, Escribir y Buscar

//Otra forma de escribir los ficheros, con la clase StreamWriter


var sw = new StreamWriter(ruta);

sw.WriteLine("Buenos días");
sw.Write("En esta carta"); //En la misma línea
sw.WriteLine($"te informo que la hora es { DateTime.Now.ToString("hh: mm:ss")}");

sw.Dispose(); //limpiar los recursos utilizados por el streamWriter, recursos que nosotros no tenemos el control



//Si lo volvemos a ejecutar se sobreescribe la información, si lo que queremos es añadirla,

var streaWriter = new StreamWriter(ruta, append: true);

//Como usar el método Dispose es tan importante, se puede utilizar la sentencia Using al definirlo y
//así no se nos olvida cerrarlo.

using (var streamWriter = new StreamWriter(ruta))
{
    streamWriter.WriteLine("Hola");
} //Automáticamnte, aquí es cuando se va a llamar al método Dispose.

//Otra forma de leer los ficheros, con la clase StreamReader


using (var sr = new StreamReader(ruta))
{
    var linea = sr.ReadLine();
    while (linea != null)
    {
        Console.WriteLine(linea);
        linea = sr.ReadLine();
    }
}




