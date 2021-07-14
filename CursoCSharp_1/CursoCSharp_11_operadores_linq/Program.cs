using CursoCSharp_10_clausula_groupby;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp_11_operadores_linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Libro> libros = Libro.GetLibros();

            //Operadores matematicos

            var count = libros.Count();                 //cuantos operadores tiene el listado

            var suma = libros.Sum(x => x.Precio);       //se le pasa una expresion de lo que queremos que nos sume, nos va a hacer la suma de todos los elementos del listado
                
            var maximo = libros.Max(x => x.Precio);     //saca el valor maximo de la expresion

            var minimo = libros.Min(x => x.Precio);     //saca el valor minimo

            var media = libros.Average(x => x.Precio);  //saca la media del valor seleccionado del listado

            //operadores miembro

            var toma = libros.Take(2);                  //toma tantos elementos como le digamos 

            var salta = libros.Skip(5);                 //salta tantos elementos como le digamos

            var tomaYSalta = libros.Skip(2).Take(3);    //esto sirve para los paginados, cada cambio de pagina se salta dos y luego coge los 3 siguientes y asi

            var vuelta = libros.Reverse<Libro>();       //le da la vuelta a como tenemos ordenado el listado

            var usarfirst = libros.First();             //first coge el primer elemento del listado

            var primero = libros.Where(x=> x.Titulo.Length > 0).OrderBy(x=> x.Precio).First();      //se puede usar first despues de usar un filtrado, como en este caso

            var primeroONulo = libros.FirstOrDefault(); //devuelve el primer valor o si no hay valores, devuelve un por defecto

            var elementoEn = libros.ElementAt(4);       //devuelve el elemento del listado en la posicion 4

            var ultimo = libros.Last();                 //devuelve el ultimo elemento en el listado

            var single = libros.Single(x => x.ISBN.Contains("22")); //devuelve el primer objeto que encuentre que cumpla la condicion pasada por la expresion

            var alguno = libros.Any();                  //si tiene algun elemento devuelve true, si no tiene devuelve false

            var condicionTodos = libros.All(x => x.Titulo.Length > 0);  //si todos los elementos del listado cumple una condicion, devuelve true. Si no devuelve false

            var contiene = libros.Contains(new Libro        //contains se le tiene que pasar una clase del tipo que contiene para ver si lo contiene o no lo contiene
            {
                FechaSalida = DateTime.Now.AddYears(-3),
                ISBN = "111111",
                Precio = 12.22M,
                Titulo = "El señor de los anillos"
            });
        }
    }
}
