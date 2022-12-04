<Query Kind="Program">
  <Namespace>System.Security.Cryptography</Namespace>
</Query>

void Main()
{
	Console.WriteLine(GetHashString1("1"));
	Console.WriteLine(GetHashString("1"));
}

Guid GetHashString(string s)  
{  
  //переводим строку в байт-массим  
  byte[] bytes = Encoding.Unicode.GetBytes(s);  

  //создаем объект для получения средст шифрования  
  MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();  
      
  //вычисляем хеш-представление в байтах  
  byte[] byteHash = CSP.ComputeHash(bytes);  

  string hash = string.Empty;  

  //формируем одну цельную строку из массива  
  foreach (byte b in byteHash)
     hash += string.Format("{0:x2}", b);  

  return new Guid(hash);  
}  
// You can define other methods, fields, classes and namespaces here

string GetHashString1(string s)  
    {  
      //переводим строку в байт-массим  
      byte[] bytes = Encoding.Unicode.GetBytes(s);  
  
      //создаем объект для получения средст шифрования  
      MD5CryptoServiceProvider CSP =  
          new MD5CryptoServiceProvider();  
          
      //вычисляем хеш-представление в байтах  
      byte[] byteHash = CSP.ComputeHash(bytes);  
  
      string hash = string.Empty;  
  
      //формируем одну цельную строку из массива  
      foreach (byte b in byteHash)  
          hash += string.Format("{0:x2}", b);  
  
      return hash;  
    }  