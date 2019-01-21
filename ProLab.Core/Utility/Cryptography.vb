Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Security.Cryptography
Imports System.Text
Imports System.Threading.Tasks

Public Module Cryptography

    Private passPhrase As String = "ProLab"
    Private saltValue As String = "ProLab@ProLab"
    Private hashAlgorithm As String = "SHA1"
    Private passwordIterations As Integer = 2
    Private initVector As String = "@1B2c3D4e5F6g7H8"
    Private keySize As Integer = 256

    Function OneWayHash(ByVal input As String) As String
        Dim x As MD5CryptoServiceProvider = New MD5CryptoServiceProvider()
        Dim bs As Byte() = Encoding.UTF8.GetBytes(input)
        bs = x.ComputeHash(bs)
        Dim s As StringBuilder = New StringBuilder()
        For Each b As Byte In bs
            s.Append(b.ToString("x2").ToLower())
        Next
        input = s.ToString()
        Return input
    End Function

    Function EncryptString(ByVal input As String) As String
        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)
        Dim plainTextBytes As Byte() = Encoding.UTF8.GetBytes(input)
        Dim password As PasswordDeriveBytes = New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)
        Dim keyBytes As Byte() = password.GetBytes(keySize / 8)
        Dim symmetricKey As RijndaelManaged = New RijndaelManaged()
        symmetricKey.Mode = CipherMode.CBC
        Dim encryptor As ICryptoTransform = symmetricKey.CreateEncryptor(keyBytes, initVectorBytes)
        Dim memoryStream As MemoryStream = New MemoryStream()
        Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write)
        cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length)
        cryptoStream.FlushFinalBlock()
        Dim cipherTextBytes As Byte() = memoryStream.ToArray()
        memoryStream.Close()
        cryptoStream.Close()
        Dim cipherText As String = Convert.ToBase64String(cipherTextBytes)
        Return cipherText
    End Function

    Function DecryptString(ByVal cipherText As String) As String
        Dim initVectorBytes As Byte() = Encoding.ASCII.GetBytes(initVector)
        Dim saltValueBytes As Byte() = Encoding.ASCII.GetBytes(saltValue)
        Dim cipherTextBytes As Byte() = Convert.FromBase64String(cipherText)
        Dim password As PasswordDeriveBytes = New PasswordDeriveBytes(passPhrase, saltValueBytes, hashAlgorithm, passwordIterations)
        Dim keyBytes As Byte() = password.GetBytes(keySize / 8)
        Dim symmetricKey As RijndaelManaged = New RijndaelManaged()
        symmetricKey.Mode = CipherMode.CBC
        Dim decryptor As ICryptoTransform = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes)
        Dim memoryStream As MemoryStream = New MemoryStream(cipherTextBytes)
        Dim cryptoStream As CryptoStream = New CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read)
        Dim plainTextBytes As Byte() = New Byte(cipherTextBytes.Length - 1) {}
        Dim decryptedByteCount As Integer = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length)
        memoryStream.Close()
        cryptoStream.Close()
        Dim plainText As String = Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount)
        Return plainText
    End Function
End Module


