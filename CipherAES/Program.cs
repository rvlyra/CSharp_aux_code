using System.Security.Cryptography;
using System.Text;

var mensagem = "rvlyra.com.br";
byte[] chave = new byte[16];
RandomNumberGenerator.Fill(chave);

Console.WriteLine("========== CRIPTOGRAFANDO =============");

Aes aes = Aes.Create();
eas.key = chave;
var ciphertext = aes.EncryptEcb(Encoding.UTF8.GetBytes(mensagem), PaddingMode.PKCS7);


Console.WriteLine($"Mensagem: {mensagem}");
Console.WriteLine($"Senha: {Convert.ToHexString(chave)}");
Console.WriteLine($"Cipher: {Convert.ToHexString(ciphertext)}");
Console.WriteLine();

Console.WriteLine("========== DECRIPTOGRAFANDO =============");

Console.WriteLine($"Cipher: {Convert.ToHexString(ciphertext)}");


