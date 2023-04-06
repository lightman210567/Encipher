using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lightman210567.Encipher;

namespace UnitTests
{
    [TestClass]
    public class VigenereCipherTests
    {
        [TestMethod]
        public void Encrypt_HelloWorld_EqualKey()
        {
            string PlainText = "hello world";
            string Key = "hello world";

            string CipherText = Encipher.VigenereEncrypt(PlainText, Key);

            Assert.AreEqual("oiwwc sciwg", CipherText);
        }
    }
}
