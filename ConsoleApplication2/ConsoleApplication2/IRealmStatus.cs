using System.ServiceModel;
using System.ServiceModel.Web;

namespace ConsoleApplication2
{
   [ServiceContract]    
   public interface IRealmStatus
   {
      [OperationContract,
       WebGet(         
         UriTemplate = "realm/status?realms={realms}",   
         ResponseFormat = WebMessageFormat.Json)]
      RealmStatusResponse GetStatus(string realms);
   }
}
