using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ConsoleApplication2
{   
   public enum RealmType
   {      
      PvE,      
      PvP
   }
   
   public enum RealmPopulation
   {
      Low,
      Medium,
      High,
      Full
   }

   [DataContract]
   public class Realm
   {
      //hack since the JsonDataContractSerializer doesn't handle enums properly
      public RealmType Type 
      { 
         get 
         { 
            return (RealmType)Enum.Parse(typeof(RealmType), m_realmType, true); 
         } 
      }

      public RealmPopulation Population
      {
         get
         {
            return (RealmPopulation)Enum.Parse(typeof(RealmPopulation), m_population, true);
         }
      }

      [DataMember(Name = "type")]
      private string m_realmType { get; set; }

      [DataMember(Name = "queue")]
      public bool Queue { get; set; }

      [DataMember(Name = "status")]
      public bool Status { get; set; }

      [DataMember(Name = "population")]
      private string m_population { get; set; }

      [DataMember(Name = "name")]
      public string Name { get; set; }

      [DataMember(Name = "slug")]
      public string Slug { get; set; }

      public Realm()
      {}
   }

   [DataContract]
   public class RealmStatusResponse
   {
      [DataMember(Name = "realms")]
      public IList<Realm> Realms { get; set; }

      public RealmStatusResponse()
      {}
   }
}
