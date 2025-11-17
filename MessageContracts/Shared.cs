namespace MessageContracts
{
    public record ProductCreated(Guid StoreID, Product Product);

    public record ProductDeleted(Guid StoreID, Guid ProductId);


    public record CreateProduct(ProductExtended ProductExtended);

    public record DeleteProduct(Guid StoreID, Guid ProductId);

    public class Product
    {
        public Guid ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal MinPrice { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }
    }

    public class ProductExtended: Product
    {
        public Guid StoreId { get; set; }
    }
}
