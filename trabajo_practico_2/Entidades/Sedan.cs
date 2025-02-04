﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        private ETipo tipo;

        /// <summary>
        /// Por defecto, TIPO será CuatroPuertas
        /// </summary>
        /// <param name="marca"></param>
        /// <param name="chasis"></param>
        /// <param name="color"></param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color) : this(marca, chasis, color, ETipo.CuatroPuertas)
        {
            
        }

        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo) : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }

        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        /// <summary>
        /// ya al metodo Mostrar de la clase Padre y le agrega los atributos propios de la clase Sedan
        /// </summary>
        /// <returns></returns>
        public override sealed string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"TIPO  : {this.tipo.ToString()}");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        /// <summary>
        /// Los posibles valores de tipo
        /// </summary>
        public enum ETipo { 
            CuatroPuertas, 
            CincoPuertas 
        }
    }
}
