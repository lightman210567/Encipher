using lightman210567.Encipher;

namespace UnitTests
{
    [TestClass]
    public class AtbashCipher
    {
        [TestMethod]
        public void Encode_HelloWorld()
        {
            string PlainText = "hello world";

            string CipherText = lightman210567.Encipher.Encipher.AtbashCipher(PlainText);

            Assert.AreEqual("svool dliow", CipherText);
        }

        [TestMethod]
        public void Decode_HelloWorld()
        {
            string CipherText = "svool dliow";

            string PlainText = lightman210567.Encipher.Encipher.AtbashCipher(CipherText);

            Assert.AreEqual("hello world", PlainText);
        }

        [TestMethod]
        public void Encode_Alphabet()
        {
            string PlainText = "abcdefghijklmnopqrstuvwxyz";

            string CipherText = lightman210567.Encipher.Encipher.AtbashCipher(PlainText);

            Assert.AreEqual("zyxwvutsrqponmlkjihgfedcba", CipherText);
        }

        [TestMethod]
        public void Decode_Alphabet()
        {
            string CipherText = "zyxwvutsrqponmlkjihgfedcba";

            string PlainText = lightman210567.Encipher.Encipher.AtbashCipher(CipherText);

            Assert.AreEqual("abcdefghijklmnopqrstuvwxyz", PlainText);
        }
    }
}