using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Simulacion_PC.Models
{    

    [Table("t_solicitud")]
    public class Solicitud
    {
       
       [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
       public int Id {get; set;}
       
       public string nombre {get; set;}

       public string foto {get; set;}

       public string descripcion {get; set;}

       public decimal precio {get; set;}

       public string celular {get; set;}

       public string lugar{get; set;}

       public string comprador {get; set;}

       public DateTime fecha {get; set;}

       public Categoria Categoria {get; set;}

       
       public Solicitud()
       {

           this.fecha = DateTime.Now;
           
       }
       

    }
}