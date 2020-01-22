namespace Estrategia.Servicio.Implementacion
{
    class ImagenPNG : IEstrategia
    {
        private string cMensaje { get; set; }

        public ImagenPNG(string _cMensaje)
        {
            cMensaje = _cMensaje;
        }
        public string GenerarImagen(string _cNombre)
        {
            return string.Format(cMensaje, _cNombre, "PNG");
        }
    }
}
