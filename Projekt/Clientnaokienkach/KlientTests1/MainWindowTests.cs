using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clientnaokienkach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clientnaokienkach.Tests
{
    [TestClass()]
    public class MainWindowTests
    {
        [TestMethod()]
        public void MainWindowTest()
        {
            string sol = Pizza.Adding(10, 20);
            Assert.AreEqual("30", sol);
        }
    }
}