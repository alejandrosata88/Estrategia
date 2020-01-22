using Estrategia.Servicio;
using Estrategia.Servicio.Implementacion;
using System;

namespace Estrategia.Controlador
{
    public class Cliente
    {
        public void Main()
        {
            string cTexto = string.Empty, cFormato = string.Empty, cMensaje=string.Empty;
            string cMensajeInterno = "Se ha guardado la imagen {0}.{1}";
            IEstrategia IEstrategia = null;
            Contexto contexto = new Contexto();
            Console.WriteLine("Formatos\n1-BMP\n2-JPG\n3-JPG");

            while (cTexto != "x")
            {
                cMensaje = "";
                Console.WriteLine("Ingrese el nombre de la Imagen");
                cTexto = Console.ReadLine();
                Console.WriteLine("Seleccione el Formato a Generar");
                cFormato= Console.ReadLine();
 
                switch(cFormato)
                {
                    case "1":
                        {
                            IEstrategia = new ImagenBMP(cMensajeInterno);
                        }
                        break;
                    case "2":
                        {
                            IEstrategia = new ImagenJPG(cMensajeInterno);
                        }
                        break;
                    case "3":
                        {
                            IEstrategia = new ImagenPNG(cMensajeInterno);
                        }
                        break;
                    default:
                        cMensaje = "Error";
                        break;
                }

                if (string.IsNullOrEmpty(cMensaje))
                {
                    contexto.AsignarEstrategia(IEstrategia);
                    cMensaje = contexto.RealizarAccion(cTexto);
                }
                Console.WriteLine(cMensaje);
                Console.WriteLine("ingrese 'x' para salir o cualquier otra tecla para continuar");
                cTexto =Console.ReadLine();
            }
        }
    }
}
