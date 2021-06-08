namespace hello_docker
{
    public class HelloDocker
    {
        public string Content { get; set; }
        public string Environment { get; set; }

        public HelloDocker(string Content, string Environment)
        {
            this.Content = Content;
            this.Environment = Environment;
        }
    }
}
