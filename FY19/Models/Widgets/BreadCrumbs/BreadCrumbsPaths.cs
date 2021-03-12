
namespace FY19.Models.Widgets
{
    public class BreadCrumbsPaths
    {
        public BreadCrumbsPaths(string path, string title, int node)
        {
            this.Path = path;
            this.Title = title;
            this.Node = node;
        }
        public string Path { get; private set; }
        public string Title { get; private set; }
        public int Node { get; private set; }
    }
}