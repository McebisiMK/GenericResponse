using GenericValidatableResponse.Extensions;

namespace GenericValidatableResponse
{
    public class ValidatableResponse
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

        public void MergeResponses(ValidatableResponse response)
        {
            if (response is null) return;

            Errors.AddRange(response.Errors);
            Messages.AddRange(response.Messages);
        }

        public T MergeResponseWithData<T>(GenericResponse<T> genericResponse)
        {
            var response = default(T);

            MergeResponses(genericResponse as ValidatableResponse);

            if (IsValid)
                response = genericResponse.Data;

            return response;
        }
    }
}