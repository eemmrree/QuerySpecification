using QuerySpecification.Data.Repositories;
using QuerySpecification.Domain.Entities;
using QuerySpecification.Domain.QuerySpecification;

namespace QuerySpecification.Application
{
    public class ProductService : IProductService
    {
        private readonly CrudRepo<Product> _crudRepo;

        public ProductService(CrudRepo<Product> crudRepo)
        {
            _crudRepo = crudRepo;
        }

        public void GetAll()
        {
            var specification = new AllProductSpec();
            var specUnitsInStock = new InStockProductSpec();
            _crudRepo.FindAll(specification.And(specUnitsInStock));
        }
    }
}