using AllenamentoEfficace;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
        [DataTestMethod]
        [DataRow(78,true)]
        [DataRow(68,true)]
        [DataRow(61,true)]
        [DataRow(94,true)]
        [DataRow(62,true)]
        [DataRow(78,true)]
        [DataRow(66,true)]
        [DataRow(58,false)]
        [DataRow(88,true)]
        [DataRow(100,true)]
        public void BattitiRiposo(int battiti, bool risultato)
        {
            bool risposta = Gestione.BattitiRisposo(battiti);
            Assert.AreEqual(risultato, risposta);
        }

    }
}
