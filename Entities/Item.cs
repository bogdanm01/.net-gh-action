using System;

namespace Catalog.Entities
{
    /*
        * Record type: https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/tutorials/records
    */
    public record Item
    {
        /* 
        * init allows setting a value ONLY upon initialization, 
        * great for immutable fileds such as id
        */
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}