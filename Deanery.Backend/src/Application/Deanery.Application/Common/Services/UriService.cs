using Deanery.Application.Common.Contracts;
using Deanery.Application.Common.Pagination.Queries;
using Microsoft.AspNetCore.WebUtilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deanery.Application.Common.Services
{
    public class UriService : IUriRepository
    {
        private readonly string _baseUri;

        public UriService(string baseUri)
        {
            _baseUri = baseUri;
        }

        public Uri GetAllAdvertsUri(PaginationQuery query = null)
        {
            var uri = new Uri(_baseUri);

            if (query == null)
            {
                return uri;
            }

            var modifiedUri = QueryHelpers.AddQueryString(_baseUri, "pagenumber", query.PageNumber.ToString());
            modifiedUri = QueryHelpers.AddQueryString(modifiedUri, "pagesize", query.PageSize.ToString());

            return new Uri(modifiedUri);
        }
    }
}
