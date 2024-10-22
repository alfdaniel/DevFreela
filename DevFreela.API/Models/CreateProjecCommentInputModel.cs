namespace DevFreela.API.Models
{
    public class CreateProjecCommentInputModel
    {
        public string Content { get; set; }
        public int IdProject { get; set; }
        public int IdUser { get; set; }
    }
}
