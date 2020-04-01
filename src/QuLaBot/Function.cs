using System.Collections.Generic;
using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace QuLaBot
{
    public sealed class Function
    {

        /// <summary>
        /// A simple function that takes a string and does a ToUpper
        /// </summary>
        public APIGatewayProxyResponse Handle(APIGatewayProxyRequest apigProxyEvent)
        {
            return new APIGatewayProxyResponse
            {
                Body = "{ \"something\": 12 }",
                Headers = new Dictionary<string, string> {{"Content-Type", "application/json"}},
                StatusCode = 200,
            };
        }
    }
}
