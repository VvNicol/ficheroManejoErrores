using FicheroVariosF_modificar_insetar_guardar_ej7.Servicio;
using System.IO;

namespace FicheroVariosF_modificar_insetar_guardar_ej7
{
    internal class Program
    {
        static string textofichero = "miTexto.txt";
        static string archivo = "miArchivo.txt";

        static void Main(string[] args)
        {
            MenuInterface mi = new MenuImplementacion();
            
            bool esCerrado = false;
            int opcionElegida;

            if(!File.Exists(textofichero))
            {
                using (StreamWriter st = new StreamWriter(textofichero))
                {
                    st.WriteLine("Texto 0        ");
                    st.WriteLine("Texto 1        ");
                    st.WriteLine("Texto 2        ");
                    st.WriteLine("Texto 3        ");
                    st.WriteLine("Texto 4        ");
                    st.WriteLine("Texto 5        ");
                    st.WriteLine("Texto 6        ");
                    st.WriteLine("Texto 7        ");
                    st.WriteLine("Texto 8        ");
                    st.WriteLine("Texto 9        ");
                }
            }
            
            if(!File.Exists(archivo))
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.WriteLine("Archivo 0        ");
                    sw.WriteLine("Archivo 1        ");
                    sw.WriteLine("Archivo 2        ");
                    sw.WriteLine("Archivo 3        ");
                    sw.WriteLine("Archivo 4        ");
                    sw.WriteLine("Archivo 5        ");
                    sw.WriteLine("Archivo 6        ");
                    sw.WriteLine("Archivo 7        ");
                    sw.WriteLine("Archivo 8        ");
                    sw.WriteLine("Archivo 9        ");
                }
            }          

            try
            {
                do
                {
                    opcionElegida = mi.MenuPrincipal();
                    switch (opcionElegida)
                    {
                        case 0:
                            esCerrado = true;
                            break;
                        case 1:
                            mi.MenuTextoFichero();
                            break;
                        case 2:
                            mi.MenuArchivoFichero();
                            break;                      
                        default: Console.WriteLine("La opcion no existe");
                            break;
                    }

                } while (!esCerrado);

            }
            catch (IOException io)
            {
                Console.WriteLine("Error al leer o escribir : " + io.Message);
            }
        }
    }
}
