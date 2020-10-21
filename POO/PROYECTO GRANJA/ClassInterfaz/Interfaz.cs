using System;
using ClassGranja.Granja;
using ClassCultivo.Cultivo;
using ClassRobot.Robot;

namespace ClassInterfaz.Interfaz
{
    public class interfazGranja
    {
        public Granja granjaPrincipal = new Granja();
        void menu()
        {
            Console.WriteLine("==============================================");
            Console.WriteLine("¡Bienvenido a la granja de lo que tu quieras!");
            Console.WriteLine("==============================================");
            Console.WriteLine("¿Que deseas hacer?");
            Console.WriteLine("1) Mostrar Estado de la granja.");
            Console.WriteLine("2) Sembrar Cultivos.");
            Console.WriteLine("3) Proteger Cultivos.");
            Console.WriteLine("4) Desproteger Cultivos.");
            Console.WriteLine("5) Mostrar Temperatura actual");
            Console.WriteLine("6) Mandar robot a regar cultivo");
            Console.WriteLine("7) Cerrar.");
            Console.WriteLine("==============================================");
        }
        public void menuGranja(){
            int op;
            menu();
            op = Int32.Parse(Console.ReadLine());
            while(op != 7){
                if(op == 1){
                    granjaPrincipal.mostrarEstadoCultivos();
                }
                if(op == 2){
                    granjaPrincipal.sembrarCultivos();
                }
                if(op == 3){
                    granjaPrincipal.protegerCultivos();
                }
                if(op == 4){
                    granjaPrincipal.desprotegerCultivos();
                }
                if(op == 5){
                    granjaPrincipal.mostrarTempAct();
                }
                if(op == 6){
                    granjaPrincipal.mandarRobotARegar();
                }
                menu();
                op = Int32.Parse(Console.ReadLine());
            }
        }
    }
}