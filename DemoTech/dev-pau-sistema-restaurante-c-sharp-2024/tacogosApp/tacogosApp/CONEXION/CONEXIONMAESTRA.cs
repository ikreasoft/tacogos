using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tacogosApp.CONEXION
{
    internal class CONEXIONMAESTRA
    {
        // Lectura del fichero XML con la cadena de conexión del servidor
        public static string conexionMaestraSistema = Convert.ToString(LIBRERIAS.Desencryptacion.checkServer());
    }
}
