namespace Poc.GraphQL.Web.Models
{
    public class GraphQLRequestModel
    {
        public string Query { get; set; }

        public string OperationName { get; set; }

        public dynamic Variables { get; set; }
    }
}