using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoUsadosGrupo4
{
    internal class Prestamo
    {
        public decimal Precio { get; set; }              
        public decimal Prima { get; set; }                
        public int MesesPlazo { get; set; }              
        public decimal TasaInteres { get; set; }          
        public decimal ServiciosAdicionales { get; set; } 

        public decimal Impuesto { get; private set; }
        public decimal CuotaMensual { get; private set; }
        public decimal TotalFactura { get; private set; }

        public Prestamo(decimal precio, decimal prima, int mesesPlazo, decimal tasaInteres, decimal serviciosAdicionales)
        {
            Precio = precio;
            Prima = prima;
            MesesPlazo = mesesPlazo;
            TasaInteres = tasaInteres;
            ServiciosAdicionales = serviciosAdicionales;
        }

        public bool Calcular()
        {
            // Validaciones con MessageBox
            if (MesesPlazo <= 0 || MesesPlazo > 60)
            {
                MessageBox.Show("El plazo debe ser mayor que 0 y hasta 60 meses.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Prima < 3600000)
            {
                MessageBox.Show("La prima debe ser mayor o igual a 3,600,000.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (Precio <= 0)
            {
                MessageBox.Show("El precio del vehículo debe ser mayor que 0.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (TasaInteres <= 0)
            {
                MessageBox.Show("La tasa de interés debe ser mayor que 0.",
                                "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            // IVA 13%
            Impuesto = Precio * 0.13m;

            // Precio + impuesto
            decimal costoConImpuesto = Precio + Impuesto;

            // Costo a financiar (vehículo + impuesto + servicios adicionales - prima)
            decimal costoFinanciar = (costoConImpuesto + ServiciosAdicionales) - Prima;

            // Interés mensual
            decimal interesMensual = (TasaInteres / 100m) / 12m;

            // Fórmula de cuota mensual (amortización francesa)
            decimal cuotaBase = costoFinanciar * (interesMensual /
                                (1 - (decimal)Math.Pow((double)(1 + interesMensual), -MesesPlazo)));

            CuotaMensual = cuotaBase;

            // Total factura incluye vehículo + impuesto + servicios adicionales
            TotalFactura = costoConImpuesto + ServiciosAdicionales;

            return true; // cálculo exitoso
        }
    }
}