using Encipher;

namespace UnitTests
{
    [TestClass]
    public class AtbashCipher
    {
        [TestMethod]
        public void Encode_HelloWorld()
        {
            string PlainText = "hello world";

            string CipherText = Encipher.Encipher.EncipherText(PlainText, "atbash cipher");

            Assert.AreEqual(CipherText, "svool dliow");
        }

        [TestMethod]
        public void Decode_HelloWorld()
        {
            string CipherText = "svool dliow";

            string PlainText = Encipher.Encipher.EncipherText(CipherText, "atbash cipher");

            Assert.AreEqual(PlainText, "hello world");
        }

        [TestMethod]
        public void Encode_Alphabet()
        {
            string PlainText = "abcdefghijklmnopqrstuvwxyz";

            string CipherText = Encipher.Encipher.EncipherText(PlainText, "atbash cipher");

            Assert.AreEqual(CipherText, "zyxwvutsrqponmlkjihgfedcba");
        }

        [TestMethod]
        public void Decode_Alphabet()
        {
            string CipherText = "zyxwvutsrqponmlkjihgfedcba";

            string PlainText = Encipher.Encipher.EncipherText(CipherText, "atbash cipher");

            Assert.AreEqual(PlainText, "abcdefghijklmnopqrstuvwxyz");
        }
    }
}