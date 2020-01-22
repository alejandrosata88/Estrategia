namespace Estrategia.Servicio.Implementacion
{
    public class ImagenBMP : IEstrategia
    {
        private string cMensaje {get; set;}

        public ImagenBMP(string _cMensaje)
        {
            cMensaje = _cMensaje;
        }
        public string GenerarImagen(string _cNombre)
        {
            return string.Format(cMensaje, _cNombre, "BMP");
        }
    }
}
