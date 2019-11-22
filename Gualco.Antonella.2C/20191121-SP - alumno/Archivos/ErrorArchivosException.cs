using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Archivos
{
    public class ErrorArchivosException : Exception
    {
        #region Constructores

        /// <summary>
        /// Constructor sin parétros.
        /// Error al intentar leer o guardar un archivo.
        /// </summary>
        public ErrorArchivosException()
            : base()
        {

        }

        /// <summary>
        /// Error al intentar leer o guardar un archivo.
        /// </summary>
        /// <param name="message"></param>
        public ErrorArchivosException(string message)
            : base(message)
        {

        }

        /// <summary>
        /// Error al intentar leer o guardar un archivo
        /// </summary>
        /// <param name="innerException"></param>
        public ErrorArchivosException(Exception innerException)
            : base(innerException.Message, innerException)
        {

        }

        #endregion
    }
}
