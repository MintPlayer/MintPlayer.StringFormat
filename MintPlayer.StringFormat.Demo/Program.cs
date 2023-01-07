namespace MintPlayer.StringFormat.Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var strExample = StringExtensions.FormatAdvanced(@"Hello {0} this is {1:N2} Life should {2:yyyy:global::System.DateTime}", out var anchors, "world", "250", DateTimeOffset.Now);
        }
    }
}