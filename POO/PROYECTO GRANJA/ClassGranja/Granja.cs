using System;
using System.Collections;
using System.Collections.Generic;
using ClassCultivo.Cultivo;
using ClassRobot.Robot;
namespace ClassGranja.Granja
{
    public class Granja{

        #region Properties
        public List<Cultivo> cultivos = new List<Cultivo>();
        public List<Robot> robots = new List<Robot>();
        private int tempAct;

        public Granja( )
        {
            tempAct = 24;
        }

        #endregion Propertiess

        #region Methods
        public int GetTempAct()
            {
                return tempAct;
            }

            public void SetTempAct(int value)
            {
                tempAct = value;
            }

            public void mostrarEstadoCultivos()
            {
                int numcult;
                numcult = cultivos.Count;
                Console.WriteLine("Usted posee " + numcult);
                if(numcult > 0){
                    bool estadoProtegido;
                    string idcultivos;
                    string tipCult;
                    int temp;
                    foreach(Cultivo c in cultivos)
                    {
                        idcultivos = c.GetIdCultivo();
                        tipCult = c.GetTipoCultivo();
                        temp = c.GetTemperatura();
                        Console.WriteLine("==============================================");   
                        Console.WriteLine("Datos del cultivo: "+ idcultivos + ".");
                        Console.WriteLine("Tipo de cultivo: " + tipCult + ".");
                        Console.WriteLine("Temperatura actual es de: " + temp + ".");
                        estadoProtegido = c.GetEstadoProtegido();
                        if(estadoProtegido == true)
                        {
                            Console.WriteLine("El cultivo se encuentra protegido.");
                        }
                        else
                        {
                            Console.WriteLine("El cultivo se encuentra desprotegido.");
                        }
                        Console.WriteLine("==============================================");
                    }
                }
                else
                {
                    Console.WriteLine("Debe agregar cultivos para desplegar los datos.");
                }
            }
            public void mostrarTempAct(){
                Console.WriteLine("Hoy tenemos un temperatura de " + tempAct + "°.");
            }

            public void protegerCultivos(){
                foreach(Cultivo c in cultivos)
                {
                    c.SetEstadoProtegido(true);
                }
            }
            public void desprotegerCultivos()
            {
                foreach(Cultivo c in cultivos)
                {
                    c.SetEstadoProtegido(false);
                }
            }
            public void sembrarCultivos()
            {
                Cultivo a = new Cultivo();
                Robot r = new Robot();
                Console.WriteLine("==============================================");
                Console.WriteLine("¿De que será su parcela?:");
                Console.WriteLine("==============================================");
                a.SetTipoCultivo(Console.ReadLine());
                a.SetTemperatura(tempAct);
                Random id = new Random();
                int x;
                x = id.Next(1000,9999);
                a.SetIdCultivo(Convert.ToString(x));
                a.SetEstadoProtegido(false);
                cultivos.Add(a);
                r.SetIdRobot(Convert.ToString(x));
                robots.Add(r);
                Console.WriteLine("==============================================");
                Console.WriteLine("Parcela creada exitosamente");
                Console.WriteLine("==============================================");
            }
            public void mandarRobotARegar()
            {
                string idCultivo;
                string idRobot;
                int tam = robots.Count;
                bool flag = true;
                int i;
                Console.WriteLine("==============================================");
                Console.WriteLine("Ingrese el id del cultivo a regar:\n");
                Console.WriteLine("==============================================");
                idCultivo = Console.ReadLine();
                for(i = 0; i < tam; i++)
                {
                    idRobot = robots[i].GetIdRobot();
                    if(idRobot == idCultivo)
                    {
                        robots[i].regarCultivos(cultivos[i] ,robots[i].analizarCultivo(cultivos[i]));
                        i = tam;
                        flag = false;
                    }
                }
                if(flag == true)
                {
                    Console.WriteLine("=========================================================================");
                    Console.WriteLine("Robot del cultivo no encontrado o cultivo inexistente, contacte a soporte");
                    Console.WriteLine("=========================================================================");
                }
            }

        #endregion Methods
    }
}