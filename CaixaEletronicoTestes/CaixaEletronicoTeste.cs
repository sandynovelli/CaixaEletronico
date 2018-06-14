using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ATM;

namespace CaixaEletronicoTestes
{
    /// <summary>
    /// Summary description for CaixaEletronicoTeste
    /// </summary>
    [TestClass]
    public class CaixaEletronicoTeste
    {
        string saque = string.Empty;
        
        [TestMethod]
        public void SaqueValor0()
        {
            CaixaEletronico objCaixa = new CaixaEletronico();
            saque = objCaixa.Sacar(0);
            Assert.AreEqual("Valor indisponível", saque);
        }
        [TestMethod]
        public void SaqueNota100_1()
        {
            CaixaEletronico objCaixa = new CaixaEletronico();
            saque = objCaixa.Sacar(100);
            Assert.AreEqual("Entregar 1 nota(s) de R$100,00", saque);
        }
        [TestMethod]
        public void SaqueNota50_1()
        {
            CaixaEletronico objCaixa = new CaixaEletronico();
            saque = objCaixa.Sacar(50);
            Assert.AreEqual("Entregar 1 nota(s) de R$50,00", saque);
        }
        [TestMethod]
        public void Saque95()
        {
            CaixaEletronico objCaixa = new CaixaEletronico();
            saque = objCaixa.Sacar(95);
            Assert.AreEqual("Não há notas disponíveis para realizar este saque", saque);
        }
        [TestMethod]
        public void Saque30()
        {
            CaixaEletronico objCaixa = new CaixaEletronico();
            saque = objCaixa.Sacar(30);
            Assert.AreEqual("Entregar 1 nota(s) de R$20,00 e 1 nota(s) de R$10,00", saque);
        }
        [TestMethod]
        public void Saque80()
        {
            CaixaEletronico objCaixa = new CaixaEletronico();
            saque = objCaixa.Sacar(80);
            Assert.AreEqual("Entregar 1 nota(s) de R$50,00, 1 nota(s) de R$20,00 e 1 nota(s) de R$10,00", saque);
        }
        [TestMethod]
        public void Saque890()
        {
            CaixaEletronico objCaixa = new CaixaEletronico();
            saque = objCaixa.Sacar(890);
            Assert.AreEqual("Entregar 8 nota(s) de R$100,00, 1 nota(s) de R$50,00 e 2 nota(s) de R$20,00", saque);
        }
    }
}
