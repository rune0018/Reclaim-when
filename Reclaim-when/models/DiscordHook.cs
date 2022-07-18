namespace Reclaim_when.models
{
    public class DiscordHook
    {
        public string content { get; set; }
        public List<Embed> embeds { get; set; } = new List<Embed>();
        public List<object> attachments { get; set; } = new List<object>();

        //public DiscordHook(string content, string url)
        //{
        //    this.content = content;
        //    //embeds[0] = new Embed() { image = new Image() { url = url } };

        //}
    }

    public class Embed
    {
        public int color { get; set; }
        public Image image { get; set; }
    }

    public class Image
    {
        public string url { get; set; }
    }
}
