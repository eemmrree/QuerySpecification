using QuerySpecification.Application.Dto;
using QuerySpecification.Data.Repositories;
using QuerySpecification.Domain.Entities;
using QuerySpecification.Domain.QuerySpecification;
using System.Collections.Generic;

namespace QuerySpecification.Application
{
    public class ProductService : IProductService
    {
        private readonly CrudRepo<Product> _crudRepo;

        public ProductService(CrudRepo<Product> crudRepo)
        {
            _crudRepo = crudRepo;
        }

        public List<ProductDto> GetAll()
        {
            var specification = new AllProductSpec();
            var specUnitsInStock = new InStockProductSpec();
           var products= _crudRepo.FindAll(specification.And(specUnitsInStock));
            return (List<ProductDto>)products;
        }
    }
}