using Microsoft.AspNetCore.Mvc;
using Simulacion_PC.Models;
using Simulacion_PC.Data;
using System.Linq;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

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
                
                 var categoria = _context.DataCategorias.Find(datos);
                 solicitud.categoria = categoria;
                _context.Add(solicitud);
                _context.SaveChanges();
                return RedirectToAction("Listar");
            }

            return View(solicitud);
        }

        public IActionResult Listar(){

            var solicitudes = _context.DataContactos.ToList();

            

            return View(solicitudes);

        }
        
    }


}