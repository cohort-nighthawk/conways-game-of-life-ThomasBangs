using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using GameOfLife;

namespace UnitTestConwaysLife
{
    [TestClass]
    public class UnitTestCell
    {
      
        [TestMethod]
        public void TestWorldSize()
        {
           // object[,] cellArray = new object[12, 12]; 
            World genesis = new World();
            Assert.AreEqual(12, genesis.Length);
            Assert.AreEqual(12, genesis.Width);
        }
        [TestMethod]
        public void TestIfWorldIsEmpty()
        {
            World genesis = new World();
            
            Assert.AreEqual(0, genesis.Count() );
        }

        //if no add cells
        [TestMethod]
        public void TestThatCellIsAlive()
        {
            World genesis = new World();
            Cell cell = new Cell();
            Assert.AreEqual(true, cell.IsAlive());
        }
        
    }
}
