namespace FicheroVariosF_modificar_insetar_guardar_ej7.Servicio
{
    internal class ArchivoFicheroImplementacion : ArchivoFicheroInterface
    {
        private string archivo = "miArchivo.txt";
        public void insertarLinea()
        {
            Console.WriteLine("Ingrese el numero de la linea");
            int numeroLinea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el numero de la posicion");
            int numeroPosicion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el texto a agregar");
            string nuevoTexto = Console.ReadLine();

            string[] leerLineas = File.ReadAllLines(archivo);
            if (numeroLinea >= 1 && numeroLinea < leerLineas.Length)
            {
                string posicionLinea = leerLineas[numeroLinea - 1];
                if (numeroPosicion >= 0 && numeroPosicion < posicionLinea.Length)
                {
                    string nuevaLinea = posicionLinea.Insert(numeroPosicion, nuevoTexto);
                    leerLineas[numeroLinea - 1] = nuevaLinea;

                    Console.WriteLine("¿Desea guardar los cambios?s/n");
                    char sn = Convert.ToChar(Console.ReadLine());
                    if (sn == 's')
                    {
                        File.WriteAllLines(archivo, leerLineas);
                        Console.WriteLine("El texto se ha escrito correctamente");
                    }
                    else
                    {
                        Console.WriteLine("El texto no se ha escrito correctamente");
                    }
                }
                else
                {
                    Console.WriteLine("Fuera de rango");
                }
            }
        }

        public void modificarLinea()
        {
            Console.WriteLine("Ingrese el numero de la linea");
            int numeroLinea = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nuevo texto");
            string nuevoTexto = Console.ReadLine();

            string[] leerLineas = File.ReadAllLines(archivo);
            if (numeroLinea >= 1 && numeroLinea < leerLineas.Length)
            {
                leerLineas[numeroLinea - 1] = nuevoTexto;
                Console.WriteLine("¿Desea guardar los cambios?s/n");
                char sn = Convert.ToChar(Console.ReadLine());
                if (sn == 's')
                {
                    File.WriteAllLines(archivo, leerLineas);
                    Console.WriteLine("El texto se ha escrito correctamente");
                }
                else
                {
                    Console.WriteLine("El texto no se ha escrito correctamente");
                }
            }
            else
            {
                Console.WriteLine("Fuera de rango");
            }
        }

        public void leerFichero()
        {
            string line;
            StreamReader sr = new StreamReader(archivo);
            line = sr.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = sr.ReadLine();
            }
            sr.Close();
        }
    }
}