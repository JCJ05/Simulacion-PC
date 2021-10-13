using Microsoft.AspNetCore.Mvc;
using Simulacion_PC.Models;
using Simulacion_PC.Data;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using Microsoft.EntityFrameworkCore;

namespace Simulacion_PC.Controllers
{
    public class SolicitudController:Controller
    {

         private readonly ApplicationDbContext _context;

        public SolicitudController(ApplicationDbContext context)
        {
            _context = context;
        }
        
        public IActionResult Registro(){
             
            var categorias = _context.DataCategorias.ToList();
            
            List<SelectListItem> items = categorias.ConvertAll(d => {

                return new SelectListItem(){

                    Text = d.nombre,
                    Value = d.Id.ToString(),
                    Selected = false
                };
            });
          
           ViewBag.items = items;

            return View();

        }
        
        [HttpPost]
        public IActionResult Registro(Solicitud solicitud , int datos){
            
           

            if(ModelState.IsValid){
                
                 Categoria categoria = _context.DataCategorias.Find(datos);
                 solicitud.Categoria = categoria;
                _context.Add(solicitud);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }

            return View(solicitud);
        }

        public IActionResult Listar(){
            
            var fecha = DateTime.Now;
            var dia = fecha.Day - 5;
            var mes = fecha.Month;
            var año = fecha.Year;
            var solicitudes = _context.DataContactos.Include(s => s.Categoria).Where(b => b.fecha.Day >= dia && b.fecha.Month == mes && b.fecha.Year == año).ToList();


            return View(solicitudes);

        }
        
    }


}