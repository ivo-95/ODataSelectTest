using System;
using System.Linq;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.OData;
using System.Web.OData.Query;
using Microsoft.OData.Edm;

namespace ODataSelectTest
{
    public class CustomQueryAttribute : EnableQueryAttribute
    {
        public override IQueryable ApplyQuery(IQueryable queryable, ODataQueryOptions queryOptions)
        {
            var result = base.ApplyQuery(queryable, queryOptions);
            return result;
        }

        public override IEdmModel GetModel(Type elementClrType, HttpRequestMessage request, HttpActionDescriptor actionDescriptor)
        {
            var result =  base.GetModel(elementClrType, request, actionDescriptor);
            return result;
        }
    }
}