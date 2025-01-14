﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        private string chasis;
        private ConsoleColor color;
        private EMarca marca;
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio { get;}
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }
        /// <summary>
        /// Posibles valores de marca
        /// </summary>
        public enum EMarca
        {
            Chevrolet, 
            Ford, 
            Renault, 
            Toyota, 
            BMW, 
            Honda, 
            HarleyDavidson
        }
        /// <summary>
        /// Posibles valores de tamaño
        /// </summary>
        public enum ETamanio
        {
            Chico, 
            Mediano, 
            Grande
        }
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns> lo hacemos virtual ya que puede ser sobreescrito por cada clase derivada</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }
        /// <summary>
        /// Nos devuelve los datos del vehiculo cuando hacemos una conversion explicita
        /// </summary>
        /// <param name="p"></param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"CHASIS: {p.chasis}");
            sb.AppendLine($"MARCA : {p.marca.ToString()}");
            sb.AppendLine($"COLOR : {p.color.ToString()}");
            sb.Append($"TAMAÑO: {p.Tamanio}");

            return sb.ToString();
        }

        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>true/false</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool result = false;

            if(v1.chasis == v2.chasis)
            {
                result = true;
            }

            return result;
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1"></param>
        /// <param name="v2"></param>
        /// <returns>true/false</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}
