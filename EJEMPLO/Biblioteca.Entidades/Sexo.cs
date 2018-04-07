using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DALC;//OCUPO LA BIBLIOTECA DE ACCESO A LA bd
namespace Biblioteca.Entidades
{
   public class Sexo
    {
        public int IdSexo { get; set; }
        public String Descripcion { get; set; }
        Biblioteca.DALC.BeLifeEntities Entidades;//inicaliza
        public Sexo()
        {
            Entidades = new Biblioteca.DALC.BeLifeEntities();//crea la conexion
        }
        //metodos
        
        



    }
}
