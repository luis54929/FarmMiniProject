using System;
namespace ClassCultivo.Cultivo
{
    public class Cultivo{
        
        #region Properties
            private string tipoCultivo;
            private int temperatura;
            private bool estadoProtegido;
            private string idCultivo;

        #endregion Properties

        #region Methods
        public string GetTipoCultivo()
            {
                return tipoCultivo;
            }

            public void SetTipoCultivo(string value)
            {
                tipoCultivo = value;
            }

            public int GetTemperatura()
            {
                return temperatura;
            }

            public void SetTemperatura(int value)
            {
                temperatura = value;
            }
            public bool GetEstadoProtegido()
            {
                return estadoProtegido;
            }

            public void SetEstadoProtegido(bool value)
            {
                estadoProtegido = value;
            }
            public string GetIdCultivo()
            {
                return idCultivo;
            }
            public void SetIdCultivo(string value)
            {
                idCultivo = value;
            }
        #endregion Methods 
        
    }
}