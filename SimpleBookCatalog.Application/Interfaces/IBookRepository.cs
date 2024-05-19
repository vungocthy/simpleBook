using SimpleBookCatalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBookCatalog.Application.Interfaces
{
    public interface IBookRepository
    {
        Task AddAsync(Book book);
    }
}
