using CustomerApp.API.Dto.Responses;

namespace CustomerApp.Domain.Dto.Responses
{
    public class CommonResponseGetData<T>: CommonResponse
    {
        public T? Data { get; set; }

    }
}
