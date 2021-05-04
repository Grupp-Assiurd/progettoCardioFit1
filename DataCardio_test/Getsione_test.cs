using Microsoft.VisualStudio.TestTools.UnitTesting;
using AllenamentoEfficace;

namespace DataCardio_test
{
    [TestClass]
    public class Getsione_test
    {
        [DataTestMethod]
        [DataRow(10, "189 147")]
        [DataRow(20, "180 140")]
        [DataRow(30, "171 133")]
        [DataRow(40, "162 126")]
        [DataRow(50,"153 119")]
        [DataRow(60,"144 112")]
        [DataRow(70,"135 105")]

        public void freqMaxMin(int eta, string risultatoAspettato)
        {
            string risposta = Gestione.btmMaxMin(eta);
            Assert.AreEqual(risultatoAspettato, risposta);
        }
    }
}
