using System;

namespace Catalog.Dtos
{
    public record ItemDto
    {
        /* 
        * Data Transfer Object: actual object that is exposed
        * to client, adds flexibility
        */
        public Guid Id { get; init; }
        public string Name { get; init; }
        public decimal Price { get; init; }
        public DateTimeOffset CreatedDate { get; init; }
    }
}