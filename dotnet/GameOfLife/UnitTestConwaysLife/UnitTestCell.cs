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
        //[TestMethod]
        //public void TestThatCellsHaveBeenCreated()
        //{
        //    World genesis = new World();
        //    genesis.AddCell("x0, y0");
        //    Assert.AreEqual("x0, y0", genesis.AddCell() );
        //}
        
        //if no add cells
        
    }
}
