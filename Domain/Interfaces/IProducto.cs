using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using iText.Commons.Actions.Data;

namespace Domain.Interfaces
{
    public interface IProducto : IGenericRepositoryVarchar<Producto>
    {
        
    }
}