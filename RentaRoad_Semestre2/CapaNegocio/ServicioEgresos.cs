using Microsoft.EntityFrameworkCore;
using RentaRoad_Semestre3.CapaPresentacion;
using RentaRoad_Semestre3.Data;
using RentaRoad_Semestre3.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentaRoad_Semestre3.CapaNegocio
{
    internal class ServicioEgresos
    {
        public List<Egreso> ListarEgresos()
        {
            using (var context = new RentaRoadDbContext())
            {
                return context.Egresos.ToList();
            }
        }

        public void AgregarEgreso(Egreso nuevoEgreso)
        {
            using (var context = new RentaRoadDbContext())
            {
                context.Egresos.Add(nuevoEgreso);
                context.SaveChanges();
            }
        }

    }
}
