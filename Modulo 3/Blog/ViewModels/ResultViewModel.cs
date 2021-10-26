namespace Blog.ViewModels
{
    public class ResultViewModel<T>
    {
        public ResultViewModel(T data, T error)
        {
            Data = data;
            Error = error;
        }

        public ResultViewModel(T data)
        {
            Data = data;
        }

        public T Data { get; private set; }
        public T Error { get; private set; }
    }
}
