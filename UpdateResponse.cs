namespace heroquest.data
{
    public class UpdateResponse
    {
        public Guid OldIdempotencyKey { get; set; }
        public Guid NewIdempotencyKey { get; set; }
        public IEnumerable<TaskGroup>? TaskGroups { get; set; }
        public UIUpdate UIUpdate { get; set; }
        public bool DoReload { get; set; }
        public LoadData? ReloadData { get; set; }
    }
}
