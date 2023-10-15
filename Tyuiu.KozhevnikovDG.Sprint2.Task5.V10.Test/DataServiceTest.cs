using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.KozhevnikovDG.Sprint2.Task5.V10.Lib;

namespace Tyuiu.KozhevnikovDG.Sprint2.Task5.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfPreviousDay()
        {
            DataService ds = new DataService();

            int g = 2023;
            int m = 12;
            int n = 15;
            string res = ds.FindDateOfPreviousDay(g, m, n);
            string wait = ("2023.12.14");
            Assert.AreEqual(wait, res);



        }
    }
}
