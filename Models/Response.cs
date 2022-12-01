namespace GenericValidatableResponse
{
    public class Response<T> : ValidatableResponse
    {
        public T Data { get; set; }
    }
}