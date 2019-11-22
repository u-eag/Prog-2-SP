using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IFiles<T>
    {
        #region Propiedades

        /// <summary>
        ///  Retornará la ruta al escritorio 
        ///  (independiente de la máquina en la que se abra el programa). 
        ///  Concatena la barra final \ siendo la ruta retornada: C:\...\Desktop\.
        ///  ACLARACIÓN: Al momento de guardar, el path completo será GetDirectoryPath + nombreArchivo.
        /// </summary>
        public string GetDirectoryPath
        {
            get
            {
                return "path"; // a completar
            }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Comprobará si el archivo existe o no (sumará GetDirectoryPath al nombreArchivo recibido).
        /// </summary>
        /// <param name="nombreArchivo"></param>
        /// <returns></returns>
        public bool FileExists(string nombreArchivo)
        {
            return true; // a completar
        }

        /// <summary>
        /// Recibe el nombre de un archivo y guarda en él un dato de tipo genérico
        /// ACLARACIÓN: Al momento de guardar, el path completo será GetDirectoryPath + nombreArchivo.
        /// </summary>
        /// <param name="nombrearchivo"></param>
        /// <param name="objeto"></param>
        public void Guardar(string nombrearchivo, T objeto)
        {
            if (!(nombrearchivo is null))
            {
                XmlWriter writer = null;
                try
                {
                    writer = new XmlTextWriter(nombrearchivo, Encoding.UTF8); // para poder escribir en el archivo xml
                    XmlSerializer serializer = new XmlSerializer(typeof(T)); // creo un serializador para el tipo de objeto T
                    serializer.Serialize(writer, objeto); // guardo los datos de ese objeto en el xml
                }
                catch (Exception archivosEx) // si da error
                {
                    throw new ErrorArchivosException(archivosEx); // lanzo la excepcón
                }
                finally
                {
                    if (!(writer is null))
                    {
                        writer.Close();
                    }
                }
            }
        }

        /// <summary>
        /// Encoding del archivo. Por defecto UTF8.
        /// Recibe el nombre de un archivo y guarda en él un dato de tipo genérico
        /// ACLARACIÓN: Al momento de guardar, el path completo será GetDirectoryPath + nombreArchivo.
        /// </summary>
        /// <param name="nombrearchivo"></param>
        /// <param name="objeto"></param>
        /// <param name="encoding"></param>
        public void Guardar(string nombrearchivo, T objeto, Encoding encoding)
        {
            // algo con el encoding
            Guardar(nombrearchivo, objeto);
        }

        /// <summary>
        /// Recibe el nombre de un archivo y lee de él un dato de tipo genérico.
        /// Si falla la lectura, retorna el objeto por default.
        /// </summary>
        /// <param name="nombrearchivo"></param>
        /// <param name="objeto"></param>
        /// <returns></returns>
        public bool Leer(string nombrearchivo, out T objeto)
        {
            bool retorno = false;
            objeto = default(T); // null genérico para limpiar la variable

            if (!(nombrearchivo is null))
            {
                XmlReader lector = null;

                try
                {
                    lector = new XmlTextReader(nombrearchivo);
                    XmlSerializer serializador = new XmlSerializer(typeof(T));
                    objeto = (T)serializador.Deserialize(lector); // levanto el dato genérico según su tipo
                    retorno = true;
                }
                catch (Exception archivoEx)
                {
                    throw new ErrorArchivosException(archivoEx);
                }
                finally
                {
                    if (!(lector is null))
                    {
                        lector.Close();
                    }
                }
            }
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nombrearchivo"></param>
        /// <param name="objeto"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public bool Leer(string nombrearchivo, out T objeto, Encoding encoding)
        {
            objeto = default(T);

            // algo con el encoding

            return true; // a completar
        }

        #endregion

    }
}
