using GenericResponse.Extensions;

namespace GenericResponse.Models
{
    public class Response<T> : Response
    {
        public T Data { get; set; }
    }

    public class Response
    {
        public bool IsValid { get { return !Errors.Any(); } }
        public List<string> Errors { get; set; } = new List<string>();
        public List<string> Messages { get; set; } = new List<string>();

        public void AddError(string error)
        {
            if (error.HasValue())
                Errors.Add(error);
        }

        public void ClearErrors()
        {
            Errors.Clear();
        }

        public void AddMessage(string message)
        {
            if (message.HasValue())
                Messages.Add(message);
        }

        public void ClearMessages()
        {
            Messages.Clear();
        }

        public void MergeResponses(Response response)
        {
            if (response is null) return;

            Errors.AddRange(response.Errors);
            Messages.AddRange(response.Messages);
        }

        public T MergeResponseWithData<T>(Response<T> genericResponse)
        {
            var response = default(T);

            MergeResponses(genericResponse as Response);

            if (IsValid)
                response = genericResponse.Data;

            return response;
        }
    }
}