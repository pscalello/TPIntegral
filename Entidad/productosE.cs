﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidad
{
    public class productosE
    {
        //atributos

        private Guid _id;
        private Guid _idCategoria;
        private string _nombre;
        private DateTime _fechaAlta;
        private DateTime? _fechaBaja;
        private double _precio;
        private int _stock;
        private Guid _idUsuario;
        private Guid _idProveedor;

        //propiedades

        public Guid Id { get => _id; set => _id = value; }
        public Guid IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public DateTime FechaAlta { get => _fechaAlta; set => _fechaAlta = value; }
        public DateTime? FechaBaja { get => _fechaBaja; set => _fechaBaja = (DateTime)value; }
        public double Precio { get => _precio; set => _precio = value; }
        public int Stock { get => _stock; set => _stock = value; }
        public Guid IdUsuario { get => _idUsuario; set => _idUsuario = value; }
        public Guid IdProveedor { get => _idProveedor; set => _idProveedor = value; }

        // Constructor vacío
        public productosE()
        {
            Id = Guid.NewGuid(); // Generar un nuevo ID cuando se crea una instancia vacía.
        }

        public productosE(Guid id, Guid idCategoria, string nombre, DateTime fechaAlta, DateTime? fechaBaja, double precio, int stock, Guid idUsuario, Guid idProveedor)
                        : this() // Llama al constructor vacío para generar un nuevo ID
        {
            Id = id;
            IdCategoria = idCategoria;
            Nombre = nombre;
            FechaAlta = fechaAlta;
            FechaBaja = fechaBaja;
            Precio = precio;
            Stock = stock;
            IdUsuario = idUsuario;
            IdProveedor = idProveedor;
            
            //            UltimaActualizacionContraseña = FechaAlta;
        }

        //metodos


        public void SetFechaBaja(DateTime? fecha)
        {
            FechaBaja = fecha;
        }

    }
}
