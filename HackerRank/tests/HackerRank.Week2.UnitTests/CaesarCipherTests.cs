using Xunit;
using Shouldly;

namespace HackerRank.Week2.UnitTests;

public class CaesarCipherTests
{
    [Theory]
    [InlineData("Hello, World!", 3, "Khoor, Zruog!")]
    [InlineData("middle-Outz", 2, "okffng-Qwvb")]
    [InlineData("Always-Look-on-the-Bright-Side-of-Life", 5, "Fqbfdx-Qttp-ts-ymj-Gwnlmy-Xnij-tk-Qnkj")]
    public void Encrypt_ShouldEncryptInputStringCorrectly(string input, int key, string expected)
    {
        var sut = new CaesarCipher();
        var encrypted = sut.Encrypt(input, key);
        encrypted.ShouldBe(expected);
    }

    [Theory]
    [InlineData("Khoor, Zruog!", 3, "Hello, World!")]
    [InlineData("okffng-Qwvb", 2, "middle-Outz")]
    [InlineData("Fqbfdx-Qttp-ts-ymj-Gwnlmy-Xnij-tk-Qnkj", 5, "Always-Look-on-the-Bright-Side-of-Life")]
    public void Decrypt_ShouldDecryptInputStringCorrectly(string input, int key, string expected)
    {
        var sut = new CaesarCipher();
        var decrypted = sut.Decrypt(input, key);
        decrypted.ShouldBe(expected);
    }
}
