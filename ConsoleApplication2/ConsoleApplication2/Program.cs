using System;

namespace ConsoleApplication2
{
   class Program
   {
      static void Main(string[] args)
      {
         var realmStatus = new RealmStatus("wowApiEndpoint");
         var response = realmStatus.GetStatus("Medivh,Blackrock");

         foreach (var realm in response.Realms)
         {
            Console.WriteLine(string.Format("{0}, {1}", realm.Name, realm.Population));
         }

         Console.ReadKey();
      }
   }
}
