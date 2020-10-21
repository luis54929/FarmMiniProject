using System;
using ClassCultivo.Cultivo;
using ClassGranja.Granja;
using System.Collections;
using System.Collections.Generic;
namespace ClassRobot.Robot
{
    public class Robot{
        #region Properties
            private string idRobot;
        #endregion Properties

        #region Methods

            public string GetIdRobot()
            {
                return idRobot;
            }

            public void SetIdRobot(string value)
            {
                idRobot = value;
            }

            public void regarCultivos(Cultivo c, bool flag){
                int temp;
                temp = c.GetTemperatura();
                if(flag == true)
                {
                    c.SetTemperatura(temp-2);
                    Console.WriteLine("Cultivo regado exitosamente.");
                }
                else
                {
                    Console.WriteLine("No es necesario regar el cultivo.\ntemperatura actual de: "+ temp);
                }

            }
            public bool analizarCultivo(Cultivo c){
                int temp;
                temp = c.GetTemperatura();
                if(temp > 25)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        #endregion Methods
    }
    
}