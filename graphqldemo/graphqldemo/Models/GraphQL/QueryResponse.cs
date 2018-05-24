using System;
using System.Collections.Generic;
using System.Linq;

namespace graphqldemo.Models.GraphQL
{
    public class QueryResponse
    {
    }

    public class SuccessfullQueryResponse : QueryResponse
    {
        public object Data { get; }

        public SuccessfullQueryResponse(object data)
        {
            Data = data ?? throw new ArgumentNullException(nameof(data));
        }
    }

    public class FailedQueryResponse : QueryResponse
    {
        public Dictionary<string, string> Errors { get; }

        public FailedQueryResponse(IEnumerable<string> errors)
        {
            if (errors is null || !errors.Any())
                throw new ArgumentNullException(nameof(errors));

            Errors = new Dictionary<string, string>();

            foreach (var error in errors)
            {
                Errors.Add("message", error);
            }
        }
    }

    public class PartiallySuccessfullQueryResponse : QueryResponse
    {
        public object Data { get; }
        public Dictionary<string, string> Errors { get; }

        public PartiallySuccessfullQueryResponse(object data, IEnumerable<string> errors)
        {
            if (data is null || errors is null || !errors.Any())
                throw new ArgumentNullException(nameof(errors));

            Data = data;
            Errors = new Dictionary<string, string>();

            foreach (var error in errors)
            {
                Errors.Add("message", error);
            }
        }
    }
}
