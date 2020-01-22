namespace Estrategia.Servicio.Implementacion
{
    public class ImagenJPG : IEstrategia
    {
        private string cMensaje { get; set; }

        public ImagenJPG(string _cMensaje)
        {
            cMensaje = _cMensaje;
        }
        public string GenerarImagen(string _cNombre)
        {
            return string.Format(cMensaje, _cNombre, "JGP");
        }
    }
}
