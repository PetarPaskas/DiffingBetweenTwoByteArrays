namespace Descartes.Domain
{
    public class DiffingCompareResponse
    {
        public string DiffResultType { get; set; }
        public IEnumerable<Diff> Diffs { get; set; }
    }
}
