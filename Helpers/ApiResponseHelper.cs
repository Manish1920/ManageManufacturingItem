namespace ManufacturingAPI.Helpers
{
   
        public static class ApiResponseHelper
        {
            public static ApiResponse<T> CreateResponse<T>(T data, string message, bool isSuccess, int statusCode)
            {
                return new ApiResponse<T>
                {
                    status = isSuccess ? "success" : "error",
                    statusCode = statusCode,
                    message = message,
                    data = data
                };
            }
        }
        public class ApiResponse<T>
        {
            public string status { get; set; }
            public int statusCode { get; set; }
            public string message { get; set; }
            public T data { get; set; }
        }
    }

