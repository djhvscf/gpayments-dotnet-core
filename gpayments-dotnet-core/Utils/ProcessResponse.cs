using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;

namespace gpayments_core.Utils
{
    public static class ProcessResponse
    {
        public static T Process<T>(IRestResponse response) where T : class
        {
            if(IsError(response.StatusCode))
            {
                throw new Exception($"4Geeks payments returns an error. HttpCode: {response.StatusCode}, Message: {response.StatusDescription}, Content: {response.Content}");
            }

            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        public static bool Process(IRestResponse response, HttpStatusCode expectedHttpStatusCode)
        {
            if (IsError(response.StatusCode))
            {
                throw new Exception($"4Geeks payments returns an error. HttpCode: {response.StatusCode}, Message: {response.StatusDescription}, Content: {response.Content}");
            }

            return response.StatusCode == expectedHttpStatusCode;
        }

        private static bool IsError(HttpStatusCode statusCode)
        {
            return statusCode == HttpStatusCode.BadRequest
                || statusCode == HttpStatusCode.MethodNotAllowed
                || statusCode == HttpStatusCode.InternalServerError
                || statusCode == HttpStatusCode.Unauthorized
                || statusCode == HttpStatusCode.Forbidden
                || statusCode == HttpStatusCode.NotFound
                || statusCode == HttpStatusCode.ServiceUnavailable;
        }
    }
}
