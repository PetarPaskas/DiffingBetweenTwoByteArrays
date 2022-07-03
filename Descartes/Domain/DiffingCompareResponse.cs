namespace Descartes.Domain
{
    public class DiffingCompareResponse
    {
        public CompareStatus DiffResultType { get; set; }
        public IEnumerable<Diff> Diffs { get; set; }
    }
}
