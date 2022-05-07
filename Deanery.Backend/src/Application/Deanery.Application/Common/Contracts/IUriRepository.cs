using Deanery.Application.Common.Pagination.Queries;
using System;

namespace Deanery.Application.Common.Contracts
{
    public interface IUriRepository
    {
        Uri GetAllAdvertsUri(PaginationQuery query = null);
    }
}
