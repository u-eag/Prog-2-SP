using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Archivos;

namespace TestUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Intentar guardar y leer un archivo correctamente, 
        /// comprobando que los datos guardados sean iguales a los recuperados.
        /// </summary>
        [TestMethod]
        public void TestGuardarLeer()
        {
        }

        /// <summary>
        /// Intentar guardar un archivo en una ruta inválida 
        /// (una ruta vacía o con caracteres inválidos servirá para dicho plan), 
        /// comprobando que se lance la excepción ErrorArchivosException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ErrorArchivosException))]
        public void TestGuardarEnRutaInvalida()
        {
        }
    }
}
