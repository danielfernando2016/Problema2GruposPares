using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParesImpares;
using System.Collections.Generic;

namespace UnitTestGruposParesImpares
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            OrderRange objetoPrueba = new OrderRange();
            var ListadoNumeros = new List<int>();
            ListadoNumeros.Add(2);
            ListadoNumeros.Add(1);
            ListadoNumeros.Add(4);
            ListadoNumeros.Add(5);
            Console.WriteLine(objetoPrueba.build(ListadoNumeros));
            
        }

        [TestMethod]
        public void TestMethod2()
        {
            OrderRange objetoPrueba = new OrderRange();
            var ListadoNumeros = new List<int>();
            ListadoNumeros.Add(4);
            ListadoNumeros.Add(2);
            ListadoNumeros.Add(9);
            ListadoNumeros.Add(3);
            ListadoNumeros.Add(6);
           
            Console.WriteLine(objetoPrueba.build(ListadoNumeros));

        }

        [TestMethod]
        public void TestMethod3()
        {
            OrderRange objetoPrueba = new OrderRange();
            var ListadoNumeros = new List<int>();
            ListadoNumeros.Add(58);
            ListadoNumeros.Add(60);
            ListadoNumeros.Add(55);
            ListadoNumeros.Add(48);
            ListadoNumeros.Add(57);
            ListadoNumeros.Add(73);            
            Console.WriteLine(objetoPrueba.build(ListadoNumeros));

        }

    }
}
