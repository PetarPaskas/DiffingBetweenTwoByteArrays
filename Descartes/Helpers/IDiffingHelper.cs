using Descartes.Domain;

namespace Descartes.Helpers
{
    public interface IDiffingHelper
    {
        DiffingCompareResponse Compare(byte[] left, byte[] right);
    }
}
