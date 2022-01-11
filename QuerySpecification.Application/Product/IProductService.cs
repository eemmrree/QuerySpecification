using QuerySpecification.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuerySpecification.Application
{
    public interface IProductService
    {
        List<ProductDto> GetAll();
    }
}
