﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Uno de los posibles productos que hereda de Productos
    /// </summary>
    public class Droide : Producto, IFabricar<Droide>
    {
        private TipoDroide tipo;
        private int modelo;
        /// <summary>
        /// Si no le pasa el parametro de TipoDroide lo setea por default como uno de trabajo
        /// </summary>
        /// <param name="modelo"></param>
        /// <param name="stock"></param>
        /// <param name="precio"></param>
        /// <param name="modeloRebelde"></param>
        public Droide()
        {

        }
        public Droide(int modelo, int stock, int precio, bool modeloRebelde) : base(stock, precio, modeloRebelde)
        {
            this.tipo = TipoDroide.Trabajo;
            this.modelo = modelo;
        }
        public Droide(TipoDroide tipo, int modelo, int stock, int precio, bool modeloRebelde) : this(modelo, stock, precio, modeloRebelde)
        {
            this.tipo = tipo;
            this.modelo = modelo;
        }
        public int Modelo
        {
            get
            {
                return this.modelo;
            }
            set
            {
                this.modelo = value;
            }
        }
        /// <summary>
        /// El modelo debe ser mayor a 0 para lograr ensamblar
        /// </summary>
        /// <param name="objeto"></param>
        /// <returns>Devolvera true si cumple la condicion</returns>
        public bool Ensamblar(Droide objeto)
        {
            bool result = false;

            if (objeto.Modelo > 0)
            {
                result = true;
            }

            return result;
        }
        /// <summary>
        /// Si el objeto es null no indicara que se entrego
        /// </summary>
        /// <param name="objeto"></param>
        /// <returns>Devolverá el texto de entregado o arrojara una exception dependiendo 
        /// de si el objeto es nulo</returns>
        public string Entregar(Droide objeto)
        {
            string result = String.Empty;

            if (!(objeto is null))
            {
                result = "Status: Entregado";
            }
            else
            {
                throw new Exception("No se logró entregar");
            }

            return result;
        }

        /// <summary>
        /// muestra la información al respecto del droide
        /// </summary>
        /// <returns>Devuelve la info</returns>
        public override string MostrarInformación()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Producto: Droide");
            sb.AppendLine($"Tipo: {this.tipo.ToString()}");
            sb.AppendLine($"Modelo: {this.modelo}");
            sb.AppendLine($"Modelo Rebelde: {this.ModeloRebelde}");
            sb.AppendLine($"Precio: {this.Precio}");
            sb.AppendLine($"---------------------------");

            return sb.ToString();
        }
        /// <summary>
        /// Los tipos de droide posibles
        /// </summary>
        public enum TipoDroide
        {
            Trabajo,
            Astromecanico,
            Medico,
            Combate
        }
    }
}
