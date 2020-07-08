using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ApiFramework.Tests.Model
{
   public class AnimalCollection
    {
        public Animal Animal { get; set; }
    }

    public class Animal
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("organization_id")]
        public string OrganizationId { get; set; }

        [JsonProperty("url")]
        public Uri Url { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("species")]
        public string Species { get; set; }

        [JsonProperty("breeds")]
        public Breeds Breeds { get; set; }

        [JsonProperty("colors")]
        public Colors Colors { get; set; }

        [JsonProperty("age")]
        public string Age { get; set; }

        [JsonProperty("gender")]
        public string Gender { get; set; }

        [JsonProperty("size")]
        public string Size { get; set; }

        [JsonProperty("coat")]
        public string Coat { get; set; }

        [JsonProperty("attributes")]
        public Attributes Attributes { get; set; }

        [JsonProperty("environment")]
        public Environment Environment { get; set; }

        [JsonProperty("tags")]
        public List<string> Tags { get; set; }//; = new List<string>();

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("photos")]
        public List<PrimaryPhotoCropped> Photos { get; set; }

        [JsonProperty("primary_photo_cropped")]
        public PrimaryPhotoCropped PrimaryPhotoCropped { get; set; }

        [JsonProperty("videos")]
        public List<string> Videos { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        //[JsonProperty("status_changed_at")]
        [JsonIgnore]
        public DateTimeOffset StatusChangedAt { get; set; }

        //[JsonProperty("published_at")]
        [JsonIgnore]
        public DateTimeOffset PublishedAt { get; set; }

        [JsonProperty("distance")]
        public object Distance { get; set; }

        [JsonProperty("contact")]
        public Contact Contact { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }
    }

    public class Attributes
    {

        [JsonProperty("spayed_neutered")]
        public bool? SpayedNeutered { get; set; }

        [JsonProperty("house_trained")]
        public bool? HouseTrained { get; set; }

        [JsonProperty("declawed")]
        public bool? Declawed { get; set; }

        [JsonProperty("special_needs")]
        public bool? SpecialNeeds { get; set; }

        [JsonProperty("shots_current")]
        public bool? ShotsCurrent { get; set; }
    }

    public class Breeds
    {
        [JsonProperty("primary")]
        public string Primary { get; set; }

        [JsonProperty("secondary")]
        public object Secondary { get; set; }

        [JsonProperty("mixed")]
        public bool Mixed { get; set; }

        [JsonProperty("unknown")]
        public bool Unknown { get; set; }
    }

    public class Colors//: Animal
    {

        [JsonProperty("primary")]
        public string Primary { get; set; }

        [JsonProperty("secondary")]
        public string Secondary { get; set; }

        [JsonProperty("tertiary")]
        public object Tertiary { get; set; }
    }

    public class Contact
    {
        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public object Phone { get; set; }

        [JsonProperty("address")]
        public Address Address { get; set; }
    }

    public class Address
    {
        [JsonProperty("address1")]
        public object Address1 { get; set; }

        [JsonProperty("address2")]
        public object Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("postcode")]
        public string Postcode { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }
    }

    public class Environment
    {

        [JsonProperty("children")]
        public bool Children { get; set; }

        [JsonProperty("dogs")]
        public object Dogs { get; set; }

        [JsonProperty("cats")]
        public bool Cats { get; set; }
    }

    public class Links
    {
        [JsonProperty("self")]
        public Self Self { get; set; }

       // [JsonProperty("type")]
      //  public Type Type { get; set; }

        [JsonProperty("organization")]
        public Organization Organization { get; set; }
    }

    public class Organization
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

   // public class Type
   // {
   //     [JsonProperty("href")]
   //     public string Href { get; set; }
    //}
    
    public class Self
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }

    public class PrimaryPhotoCropped
    {
        [JsonProperty("small")]
        public Uri Small { get; set; }

        [JsonProperty("medium")]
        public Uri Medium { get; set; }

        [JsonProperty("large")]
        public Uri Large { get; set; }

        [JsonProperty("full")]
        public Uri Full { get; set; }
    }
}
