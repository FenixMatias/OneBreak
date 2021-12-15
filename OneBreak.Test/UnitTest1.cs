using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnBreak.ViewModelCliente;

namespace OneBreak.Test
{
    [TestClass]

    public class UnisTest1
    {
        

        [TestMethod]
        public void TestRead()
        {
            //Arrange
            ClienteVM cliente = new ClienteVM();
            string expected = (cliente.RutCliente = "555"), result;

            //Act
            cliente.ReadClient(new object());
            result = "555";

            //Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void TestCreate()
        {
            //Arrange
            ClienteVM cliente = new ClienteVM();
            string expected = cliente.RutCliente = "111", result;

            //Act
            cliente.CreateClient(new object());
            result = "111";

            //Assert
            Assert.AreEqual(expected, result);
        }

        //[TestMethod]
        //public void TestUpdate()
        //{
        //    //Arrange
        //    ClienteVM cliente = new ClienteVM();
        //    string expected = cliente.RutCliente = "111", result;

        //    //Act
        //    cliente.CreateClient(new object());
        //    result = "111";

        //    //Assert
        //    Assert.AreEqual(expected, result);
        //}

        [TestMethod]
        public void TestRead2()
        {
            //Arrange
            ClienteVM cliente = new ClienteVM();
            object o = new object();
            o = "555";
            string expected = "555", result;

            //Act
            cliente.ReadClient(o);
            result = "555";

            //Assert
            Assert.AreEqual(expected, result);
        }
    }
    
}
