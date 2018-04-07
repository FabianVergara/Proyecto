using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.DALC;
namespace Biblioteca.Entidades
{
    public class Contrato
    {
        public String NumeroContrato { get; set; }
        public DateTime Creacion { get; set; }
        public DateTime Termino { get; set; }
        public String Titular { get; set; }
        public String PlanAsociado { get; set; }
        //poliza?? la realizo aca en el diagrama de clases sale pero en el modelo no aparece
        public DateTime InicioVigencia { get; set; }
        public DateTime FinVigencia { get; set; }
        public Boolean Vigente { get; set; }
        public Boolean ConDeclaracionSalud { get; set; }
        public Double PrimaAnual { get; set; }
        public Double PrimaMensual { get; set; }
        public String Observaciones { get; set; }
        Biblioteca.DALC.BeLifeEntities Entidades;

        public Contrato()
        {
            Entidades = new BeLifeEntities();

        }
        //METODOS CRUD
        public bool GrabarContrato() {
            try
            {
                Biblioteca.DALC.Contrato Con;
                Con = new DALC.Contrato;
                Con.Numero = this.NumeroContrato;
                Con.FechaCreacion = this.Creacion;
                Con.RutCliente = this.Titular;
                Con.CodigoPlan = this.PlanAsociado;
                Con.FechaInicioVigencia = this.InicioVigencia;
                Con.FechaFinVigencia = this.FinVigencia;
                Con.Vigente = this.Vigente;
                Con.DeclaracionSalud = this.ConDeclaracionSalud;
                Con.PrimaAnual = this.PrimaAnual;
                Con.PrimaMensual = this.PrimaMensual;
                Con.Observaciones = this.Observaciones;

                Entidades.Contrato.Add(Con);
                Entidades.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
             
        }

        public bool EliminarContrato() {

        }

        public bool ActualizarContrato() {

        }

        public bool BuscarContrato() { }

        public List<Contrato> ListarTodoContrato() { }


    }
}
