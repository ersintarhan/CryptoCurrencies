namespace CryptoCurrencies.Test
{
    [TestClass]
    public class CryptCurrenciesTestClass
    {
        [TestMethod]
        public void ConvertFromText()
        {
            CryptoCurrency currency = "BTC";
            Assert.IsTrue(currency.IsValid);
            Assert.AreEqual(currency.Symbol, "BTC");
            Assert.AreEqual(currency.TestNet, false);
            Assert.AreEqual(currency.MainNet, true);
            Assert.AreEqual(currency.Segwit, true);

            CryptoCurrency testCurrency = "BTCTEST";
            Assert.IsTrue(testCurrency.IsValid);
            Assert.AreEqual(testCurrency.Symbol, "BTCTEST");
            Assert.AreEqual(testCurrency.TestNet, true);
            Assert.AreEqual(testCurrency.MainNet, false);
            Assert.AreEqual(testCurrency.Segwit, true);
        }

        [TestMethod]
        public void TestToJson()
        {
            CryptoCurrency currency = "BTC";
            var json = currency.ToJson();
            Assert.AreEqual(json, "{\"IsValid\":true,\"Symbol\":\"BTC\",\"Name\":\"Bitcoin\",\"MainNet\":true,\"TestNet\":false,\"Segwit\":true,\"Type\":0,\"DefaultPath\":\"m/44’/0’/0’/0/0\",\"PathFormat\":\"m/44’/0’/0’/{0}/{1}\"}");
        }

        [TestMethod]
        public void TestDump()
        {
            CryptoCurrency currency = "BTC";
            var dumpText = currency.Dump();
            Assert.AreEqual(dumpText, "IsValid: True, Symbol: BTC, Name: Bitcoin, MainNet: True, TestNet: False, Segwit: True, Type: 0, DefaultPath: m/44’/0’/0’/0/0, PathFormat: m/44’/0’/0’/{0}/{1}");
        }

        [TestMethod]
        public void CheckInvalid()
        {
            CryptoCurrency currency = "XAB";
            Assert.IsFalse(currency.IsValid);
        }

        [TestMethod]
        public void GetAllCrypto()
        {
            var crypts = CryptoCurrency.GetAllCryptoCurrencies();
            Assert.IsNotNull(crypts);
        }


        [TestMethod]
        public void GetMainNetCrypto()
        {
            var crypts = CryptoCurrency.GetMainNetCurrencies();
            Assert.IsNotNull(crypts);
            Assert.AreEqual(crypts.Count(x => x.IsValid), 140);
            Assert.IsFalse(crypts.Any(x => x.TestNet));
        }

        [TestMethod]
        public void GetTestNetCrypto()
        {
            var crypts = CryptoCurrency.GetTestNetCurrencies();
            Assert.IsNotNull(crypts);
            Assert.AreEqual(crypts.Count(), 18);
            Assert.IsFalse(crypts.Any(x => x.MainNet));
            Assert.IsTrue(crypts.Any(x => x.Symbol == "BTCTEST"));
        }
    }
}