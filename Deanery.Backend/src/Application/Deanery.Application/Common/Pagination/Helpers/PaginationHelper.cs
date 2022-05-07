using Deanery.Application.Common.Contracts;
using Deanery.Application.Common.Pagination.Filters;
using Deanery.Application.Common.Pagination.Queries;
using Deanery.Application.Common.Pagination.Response;
using System.Collections.Generic;
using System.Linq;

namespace Deanery.Application.Common.Pagination.Helpers
{
    public class PaginationHelper
    {
        public static object CreatePaginatedResponse<T>(IUriRepository uriService, PaginationFilter paginationFilter, IEnumerable<T> list)
        {
            var nextPage = paginationFilter.PageNumber >= 1 ? uriService
                .GetAllAdvertsUri(new PaginationQuery(paginationFilter.PageNumber + 1, paginationFilter.PageSize)).ToString() : null;

            var previousPage = paginationFilter.PageNumber - 1 >= 1 ? uriService
                .GetAllAdvertsUri(new PaginationQuery(paginationFilter.PageNumber - 1, paginationFilter.PageSize)).ToString() : null;

            return new PagedResponse<T>
            {
                Data = list,
                PageNumber = (int)(paginationFilter.PageNumber >= 1 ? paginationFilter.PageNumber : (int?)null),
                PageSize = (int)(paginationFilter.PageSize >= 1 ? paginationFilter.PageSize : (int?)null),
                NextPage = list.Any() ? nextPage : null,
                PreviousPage = previousPage
            };
        }
    }
}
