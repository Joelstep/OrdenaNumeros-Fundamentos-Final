using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OrdenaNumeros;
using System.Windows;



namespace Proyecto_Bonificación
{
    [TestClass]
    public class Pruebas_juego
    {
        [TestMethod]
        public void Test_Confirmacion_Matrizes_valores()
        {
            Form1 Interfaz = new Form1();

            //Primera forma para comprobar que la matriz recibe su valor

            /*int[,] Matrizesperada = new int[4, 4];
            int valorasignado = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Matrizesperada[i, j] = valorasignado;
                    valorasignado++;
                }
            }
            Matrizesperada[0, 0] = 0;

            laLogica.AsignaValoresMatrizes();
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(Matrizesperada[i,j], laLogica.Matrizvalores[i,j]);
                }
            }*/


            //Segunda forma para comprobarlo

            int Valoresperado = 0;

            //Utilizo esta funcion para eludir el arreglo aleatorio, pues cada vez que se procese seran diferentes valores
            Interfaz.AsignaValoresMatrizes();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Assert.AreEqual(Valoresperado, Interfaz.Matrizvalores[i, j]);
                    Valoresperado++;
                }
            }
        }

        [TestMethod]
        public void Test_Confirmacion_de_Victoria()
        {

            Form1 Interfaz = new Form1();

            //Proceso para asignar a la matriz los valores correspondientes
            int valor = 1;

            for (int i = 0; i < 4; i++)
                for (int j = 0; j < 4; j++)
                {
                    Interfaz.Matrizvalores[i, j] = valor;
                    valor++;
                }
            Interfaz.Matrizvalores[3, 3] = 0;


            Assert.IsTrue(Interfaz.CondicionVictoria);
            /*for (int i = 0; i < totalFilas; i++)
                for (int j = 0; j < totalColumnas; j++)
                {
                    Assert.AreEqual(valoresEsperados[i, j], Proceso.Matrizvalores[i, j]);
                }*/

        }

        [TestMethod]
        public void Test_Confirmacion_de_segumiento_del_juego()
        {

            Form1 Interfaz = new Form1();

            int valoresperado = 0;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Interfaz.Matrizvalores[i, j] = valoresperado;
                    valoresperado++;
                }
            }

            Interfaz.EvaluaCondicionVictoria();


            Assert.IsFalse(Interfaz.CondicionVictoria);

        }

    }
}