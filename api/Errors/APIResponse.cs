using System;

namespace api.Errors
{
    public class APIResponse
    {
        public APIResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMessageForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }

        private string GetDefaultMessageForStatusCode(int statusCode)
        {
            return statusCode switch
            {
                400 => "A bad request, you have made.",
                401 => "Authorized, you are not.",
                404 => "Resource found, it was not.",
                500 => "Errors are the path to the dark side.",
                _ => null
            };
        }
    }
}