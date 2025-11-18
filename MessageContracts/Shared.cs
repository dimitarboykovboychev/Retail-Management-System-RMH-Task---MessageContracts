namespace MessageContracts
{
    public record ProductCreated(ProductDTO Product);
    public record ProductDeleted(Guid StoreID, Guid ProductID);


    public record CreateProduct(ProductDTO Product);
    public record DeleteProduct(Guid StoreID, Guid ProductID);

    public class ProductDTO
    {
        public Guid StoreID { get; set; }

        public Guid ProductID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public decimal Price { get; set; }

        public decimal MinPrice { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}
