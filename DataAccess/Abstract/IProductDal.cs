using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    
    /*
       product nesnesinin veri tabanına
       kaydedilmesi için gereken kodların şablonunu
       soyut halini oluşturduk
       Başka bir katmanı kullanmak için ona referans vermek gereklidir
       Entities katmanını kullanıcıgımız için
       referans verdik.
     */
    public interface IProductDal: IEntityRepository<Product>
    {
        List<ProductDetailDto> GetProductDetail();
    }
}
