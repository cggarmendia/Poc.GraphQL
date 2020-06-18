using System;

namespace Poc.GraphQL.Web.Exceptions
{
    public class GraphQlException : ApplicationException
    {
        public GraphQlException(string message) : base(message)
        {
        }
    }
}
