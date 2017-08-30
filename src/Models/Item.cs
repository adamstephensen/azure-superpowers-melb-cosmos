namespace todo.Models
{
    using Microsoft.Azure.Documents;
    using Newtonsoft.Json;


    public class Customer {

        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        [JsonProperty(PropertyName = "phone")]
        public bool Phone { get; set; }
    }
    public class Product
    {

        [JsonProperty(PropertyName = "productId")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "productName")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "price")]
        public decimal Price { get; set; }

        [JsonProperty(PropertyName = "qtq")]
        public decimal Quantity { get; set; }
    }
    public class Order
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "orderNumber")]
        public string OrderNumber { get; set; }

        [JsonProperty(PropertyName = "customerId")]
        public string CustomerId { get; set; }


        [JsonProperty(PropertyName = "isDeleted")]
        public bool Deleted { get; set; }

        [JsonProperty(PropertyName = "totalPrice")]
        public string TotalPrice { get; set; }

        //[JsonProperty(PropertyName = "customer")]
        //public Customer Customer { get; set; }

        //[JsonProperty(PropertyName = "items")]
        //public Product[] Items { get; set; }
    }

    public class Item
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "isComplete")]
        public bool Completed { get; set; }
    }
}