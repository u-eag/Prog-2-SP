using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void InformacionDeAvance(object sender, PlanetaEventArgs e);

    public class Planeta
    {
        private short velocidadTraslacion;
        private short posicionActual;
        private short radioRespectoSol;
        private object objetoAsociado;

        public Planeta(short velocidad, short posicion, short radioRespectoSol, object objetoVisual)
        {
            this.velocidadTraslacion = velocidad;
            this.posicionActual = posicion;
            this.objetoAsociado = objetoVisual;
            this.radioRespectoSol = radioRespectoSol;
        }

        #region Propiedades

        /// <summary>
        /// PictureBox u objeto gráfico asociado al planeta.
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public object ObjetoAsociado
        {
            get
            {
                return this.objetoAsociado;
            }
            set
            {
                this.objetoAsociado = value;
            }
        }

        /// <summary>
        /// Retorna la posicion actual
        /// </summary>
        public short PosicionActual
        {
            get
            {
                return this.posicionActual;
            }
        }

        /// <summary>
        /// Retorna el campo radioRespectoSol
        /// </summary>
        public short RadioRespectoSol
        {
            get
            {
                return this.radioRespectoSol;
            }
        }

        #endregion 

        /// <summary>
        /// Avance del planeta según su velocidad
        /// </summary>
        public short Avanzar()
        {
            this.posicionActual += velocidadTraslacion;
            return this.posicionActual;
        }

        /// <summary>
        /// Simulación del movimiento del planeta
        /// </summary>
        public void AnimarSistemaSolar()
        {
            do
            {
                PlanetaEventArgs e = new PlanetaEventArgs(this.Avanzar(), this.radioRespectoSol);
                if (this.InformarAvance != null)
                {
                    this.InformarAvance.Invoke(this, e);
                }
                System.Threading.Thread.Sleep(60 + this.velocidadTraslacion);
            } while (true);
        }

        #region Eventos

        public event InformacionDeAvance InformarAvance;

        #endregion
    }
}
