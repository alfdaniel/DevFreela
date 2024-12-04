
namespace DevFreela.Application.Models
{
    public class ResultViewModel
    {
        public bool IsSuccess { get; private set; }
        public string Message { get; private set; }

        public ResultViewModel(bool isSuccess = true, string message = "")
        {
            IsSuccess = isSuccess;
            Message = message;
        }
    }

    public class ResultViewModel<T> : ResultViewModel
    {
        public T? Data { get; private set; }

        public ResultViewModel(T? data, bool isSuccess = true, string message = "") : base(isSuccess, message)
        {
            Data = data;
        }

    }

}