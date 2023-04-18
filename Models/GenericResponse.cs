namespace GenericValidatableResponse
{
    public class GenericResponse<T> : ValidatableResponse
    {
        public T Data { get; set; }
    }
}