using System.ServiceModel;

namespace ConsoleApplication2
{
   public class RealmStatus : ClientBase<IRealmStatus>, IRealmStatus
   {  
      public RealmStatus(string endpointConfigurationName) 
         : base(endpointConfigurationName)
      {}

      #region IRealmStatus Members

      public RealmStatusResponse GetStatus(string realms)
      {
         return Channel.GetStatus(realms);
      }

      #endregion
   }
}
