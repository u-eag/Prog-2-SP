using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlanetaEventArgs : EventArgs
    {
        #region Campos

        private short avance;
        private short radioRespectoSol;

        #endregion

        #region Constructores

        /// <summary>
        /// Se cargará el atributo avance con el resultado del método Avance del Planeta
        /// y radioRespectoSol con el atributo del mismo nombre también del Planeta.
        /// </summary>
        /// <param name="avance"></param>
        /// <param name="radio"></param>
        public PlanetaEventArgs(short avance, short radio)
        {
            this.avance = avance;
            this.radioRespectoSol = radio;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Devuelve el atributo avance
        /// (con el resultado del método Avance del Planeta)
        /// </summary>
        public short Avance
        {
            get
            {
                return this.avance;
            }
        }

        /// <summary>
        /// Devuelve el atributo radioRespectoSol
        /// (con el atributo del mismo nombre también del Planeta)
        /// </summary>
        public short RadioRespectoSol
        {
            get
            {
                return this.radioRespectoSol;
            }
        }

        #endregion

    }
}
