namespace FicheroVariosF_modificar_insetar_guardar_ej7.Servicio
{
    
    internal class MenuImplementacion : MenuInterface
    {   
       
        public void MenuArchivoFichero()
        {
            ArchivoFicheroInterface aa = new ArchivoFicheroImplementacion();

            bool esCerrado = false;
            int opcionElegida;

            do
            {
                opcionElegida = ArchivoFichero();

                switch (opcionElegida)
                {
                    case 0:
                        esCerrado = true;
                        break;
                    case 1:
                        aa.insertarLinea();
                        break;
                    case 2:
                        aa.modificarLinea();
                        break;
                    case 3:
                        aa.leerFichero();
                        break;
             
                    default:
                        Console.WriteLine("La opcion no existe");
                        break;
                }

            } while (!esCerrado); 
        }

        private int ArchivoFichero()
        {

            Console.WriteLine("MI ARCHIVO");
            Console.WriteLine("0.Volver");
            Console.WriteLine("1.Insertar linea");
            Console.WriteLine("2.Modificar linea");
            Console.WriteLine("3.Leer archivo");

            int opcionArchivo = Convert.ToInt32(Console.ReadLine());
            return opcionArchivo;
        }

        public int MenuPrincipal()
        {
            Console.WriteLine("Menu Principal");
            Console.WriteLine("0.Cerrar menu");
            Console.WriteLine("1.Fichero -miTexto");
            Console.WriteLine("2.Fichero -miArchivo");

            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion; 
        }

        public void MenuTextoFichero()
        {
            TextoFicheroInterface ti = new TextoFicheroImplementacion();

            bool esCerrado = false;
            int opcionElegida;

            do
            {
                opcionElegida = TextoFichero();
                switch (opcionElegida)
                {
                    case 0:
                        esCerrado = true;
                        break;
                    case 1:
                        ti.insertarLinea();
                        break;
                    case 2:
                        ti.modificarLinea();
                        break;
                    case 3:
                        ti.leerFichero();
                        break;
                    default:
                        Console.WriteLine("La opcion no existe");
                        break;
                }

            } while (!esCerrado);
        }
        private int TextoFichero()
        {

            Console.WriteLine("MI TEXTO");
            Console.WriteLine("0.Volver");
            Console.WriteLine("1.Insertar linea");
            Console.WriteLine("2.Modificar linea");
            Console.WriteLine("3.Leer archivo");

            int opcion = Convert.ToInt32(Console.ReadLine());
            return opcion;
        }
    }
}