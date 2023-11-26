namespace heroquest.data
{
    public class InvokePlayerActionRequest
    {
        public int IdempotencyKey { get; set; }
        public string ActionName { get; set; } = string.Empty;
        public string Argument { get; set; } = string.Empty;
    }
}
