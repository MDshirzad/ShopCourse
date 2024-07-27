using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharpFunctionalExtensions;
using Shop.Catalog.Domain.Products;
using Shop.Catalog.Presentation.Contracts.Dtos.Product;

namespace Shop.Catalog.Application.Product.Contracts
{
    public interface IProductManager
    { 
    Task<Result> AddProductAsync(ProductForCreationDto productForAddDto);
   // Task<Result> UpdateProductAsync(Guid productId, ProductForUpdateDto productForUpdateDto);
   // Task<Result> DeleteProductAsync(Guid productId);
  // Task<Result< Domain.Products.Product> > GetProductByIdAsync(Guid productId);
  Task<Result<IReadOnlyList<Domain.Products.Product>>> GetAllProducts( );
    }
}