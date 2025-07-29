namespace CustomerApp.API.Dto.Responses
{
    public class CommonResponseGetData<T>: CommonResponse
    {
        public T? Data { get; set; }

    }
}
