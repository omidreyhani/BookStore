using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Saxo.ProductService
{
    public class Type
    {
        public string id { get; set; }
        public string name { get; set; }
        public string alias { get; set; }
        public string isdigital { get; set; }
    }

    public class Format
    {
        public string id { get; set; }
        public string name { get; set; }
        public string alias { get; set; }
    }

    public class Description
    {
        public string id { get; set; }
        public string datecreated { get; set; }
        public string datemodified { get; set; }
        public string description { get; set; }
        public string source { get; set; }
        public int datasupplierid { get; set; }
    }

    public class Language
    {
        public string id { get; set; }
        public string name { get; set; }
        public string alias { get; set; }
        public string isocode { get; set; }
    }

    public class Originallanguage
    {
        public string id { get; set; }
        public string name { get; set; }
        public string alias { get; set; }
        public string isocode { get; set; }
    }

    public class Delivery
    {
        public string id { get; set; }
        public string name { get; set; }
        public string alias { get; set; }
        public string groupid { get; set; }
        public string groupname { get; set; }
        public string groupalias { get; set; }
        public string availability { get; set; }
        public int deliverydays { get; set; }
        public string deliverytext { get; set; }
    }

    public class Category
    {
        public string id { get; set; }
        public string alias { get; set; }
        public string url { get; set; }
        public string name { get; set; }
    }

    public class Contributor
    {
        public string id { get; set; }
        public string alias { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Publisher
    {
        public string id { get; set; }
        public string alias { get; set; }
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Tag
    {
        public string id { get; set; }
        public string name { get; set; }
        public string alias { get; set; }
        public string url { get; set; }
    }

    public class Series
    {
        public string id { get; set; }
        public string name { get; set; }
        public string alias { get; set; }
        public string url { get; set; }
    }

    public class Supplier
    {
        public string id { get; set; }
        public string type { get; set; }
        public string productkey { get; set; }
    }

    public class Edition
    {
        public string id { get; set; }
        public string name { get; set; }
        public int value { get; set; }
        public int printingcount { get; set; }
    }

    public class Audience
    {
    }

    public class State
    {
    }

    public class Dimensions
    {
        public int length { get; set; }
        public int width { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public int pagecount { get; set; }
    }

    public class Selleritem
    {
        public int stockquantity { get; set; }
    }

    public class Product
    {
        public string id { get; set; }
        public string alias { get; set; }
        public Type type { get; set; }
        public Format format { get; set; }
        public string title { get; set; }
        public List<Description> descriptions { get; set; }
        public string url { get; set; }
        public string imageurl { get; set; }
        public string isbn10 { get; set; }
        public string isbn13 { get; set; }
        public List<string> faustnumbers { get; set; }
        public List<string> dk5codes { get; set; }
        public Language language { get; set; }
        public Originallanguage originallanguage { get; set; }
        public List<string> subtitles { get; set; }
        public string releasedate { get; set; }
        public Delivery delivery { get; set; }
        public string deliverystandard { get; set; }
        public string isorderable { get; set; }
        public string visible { get; set; }
        public int digitalprotection { get; set; }
        public int ratingcount { get; set; }
        public int ratingavg { get; set; }
        public List<Category> categories { get; set; }
        public List<Contributor> contributors { get; set; }
        public List<Publisher> publishers { get; set; }
        public List<Tag> tags { get; set; }
        public List<Series> series { get; set; }
        public List<Supplier> suppliers { get; set; }
        public string shopId { get; set; }
        public string label { get; set; }
        public Edition edition { get; set; }
        public Audience audience { get; set; }
        public State state { get; set; }
        public Dimensions dimensions { get; set; }
        public Selleritem selleritem { get; set; }
        public string seriesvolume { get; set; }
        public string originaltitle { get; set; }
        public string expecteddeliverydate { get; set; }
        public int salesscore { get; set; }
    }

    public class RootObject
    {
        public List<Product> products { get; set; }
    }
}
