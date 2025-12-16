using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ProyectoUsadosGrupo4
{
        public class DatosVehiculo
        {
            private int id_vehiculo;
            private string clase;
            private string tipo_vehiculo;
            private string marca;
            private string modelo;
            private int año;
            private string motor;
            private string combustible;
            private string transmision;
            private int pasajeros;
            private string equipamiento_basico;
            private string confort;
            private string audio_video;
            private string seguridad;
            private string otros;
            private decimal precio;
            private string imagen_path;
            private int id_estado;

            // Encapsulación
            public int IdVehiculo { get => id_vehiculo; set => id_vehiculo = value; }
            public string Clase { get => clase; set => clase = value; }
            public string TipoVehiculo { get => tipo_vehiculo; set => tipo_vehiculo = value; }
            public string Marca { get => marca; set => marca = value; }
            public string Modelo { get => modelo; set => modelo = value; }
            public int Año { get => año; set => año = value; }
            public string Motor { get => motor; set => motor = value; }
            public string Combustible { get => combustible; set => combustible = value; }
            public string Transmision { get => transmision; set => transmision = value; }
            public int Pasajeros { get => pasajeros; set => pasajeros = value; }
            public string EquipamientoBasico { get => equipamiento_basico; set => equipamiento_basico = value; }
            public string Confort { get => confort; set => confort = value; }
            public string AudioVideo { get => audio_video; set => audio_video = value; }  
            public string Seguridad { get => seguridad; set => seguridad = value; }
            public string Otros { get => otros; set => otros = value; }
            public decimal Precio { get => precio; set => precio = value; }
            public string ImagenPath { get => imagen_path; set => imagen_path = value; }
            public int IdEstado { get => id_estado; set => id_estado = value; }

            public DatosVehiculo() { }

            public DatosVehiculo(int id_vehiculo, string clase, string tipo_vehiculo, string marca, string modelo,
                                 int año, string motor, string combustible, string transmision, int pasajeros,
                                 string equipamiento_basico, string confort, string audio_video, string seguridad,
                                 string otros, decimal precio, string imagen_path, int id_estado)
            {
                this.id_vehiculo = id_vehiculo;
                this.clase = clase;
                this.tipo_vehiculo = tipo_vehiculo;
                this.marca = marca;
                this.modelo = modelo;
                this.año = año;
                this.motor = motor;
                this.combustible = combustible;
                this.transmision = transmision;
                this.pasajeros = pasajeros;
                this.equipamiento_basico = equipamiento_basico;
                this.confort = confort;
                this.audio_video = audio_video;   
                this.seguridad = seguridad;
                this.otros = otros;
                this.precio = precio;
                this.imagen_path = imagen_path;
                this.id_estado = id_estado;
            }
        }
}
