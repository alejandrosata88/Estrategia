namespace Estrategia.Servicio
{
    public class Contexto
    {
        private IEstrategia IEstrategia;

        public Contexto()
        {
        }

        public Contexto(IEstrategia _IEstrategia)
        {
            this.IEstrategia = _IEstrategia;
        }

        public void AsignarEstrategia(IEstrategia _IEstrategia)
        {
            this.IEstrategia = _IEstrategia;
        }

        public string RealizarAccion(string _cImagen)
        {
            string cMensaje = string.Empty;
            cMensaje=this.IEstrategia.GenerarImagen(_cImagen);
            return cMensaje;
        }

    }
}
