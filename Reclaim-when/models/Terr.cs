namespace Reclaim_when.models
{
    public interface Terr
    {
        public string territory { get; set; }
        public string guild { get; set; }
        public object? attacker { get; set; }
        public string acquired { get; set; }
        public Location location { get; set; }
    }
}
