using NewBlogCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewBlogCore.Interface
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> Categories { get; }
    }
}
