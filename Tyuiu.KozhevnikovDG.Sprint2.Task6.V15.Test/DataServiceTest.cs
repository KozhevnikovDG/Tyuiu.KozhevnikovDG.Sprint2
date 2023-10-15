using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KozhevnikovDG.Sprint2.Task6.V15.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint2.Task6.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void FindDayName()
        {
            DataService ds = new DataService();
            int k = 44;
            string res = ds.FindDayName(k);
            string wait = "Вторник";
            Assert.AreEqual(wait, res);
            
        }
    }
}
