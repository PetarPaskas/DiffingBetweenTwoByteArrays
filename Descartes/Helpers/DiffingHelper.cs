using Descartes.Domain;

namespace Descartes.Helpers
{
    public class DiffingHelper : IDiffingHelper
    {
        public DiffingCompareResponse Compare(byte[] left, byte[] right)
        {
            DiffingCompareResponse response = null;
            ICollection<Diff> diffs = new List<Diff>();

            if (left == null || right == null)
                throw new ArgumentNullException("Cannot have null as an argument");

            //if it's the same memory location or their length is 0; returns EqualsResponse
            if (left == right || (left.Length == 0 && right.Length == 0))
                return EqualsResponse();

            if (left.Length == right.Length)
            {
                //Compare for same length;
                bool same = true;

                for(int i = 0; i < left.Length; i++)
                {
                    if(left[i] != right[i])
                    {
                        same = false;
                        CalculateOffset(i);
                    }
                }
                if (same)
                    return EqualsResponse();
                else
                    return ContentNotMatchResponse(diffs);
            }

            return SizeNotMatchResponse();
            
            void CalculateOffset(int i) 
            {
                int offset = left[i].CompareTo(right[i]) >= 1 ? left[i] - right[i] : right[i] - left[i];
                
                diffs.Add(new Diff()
                {
                    Length = i,
                    Offset = offset
                });
            }
        }

        private DiffingCompareResponse SizeNotMatchResponse()
        {
            return new()
            {
                DiffResultType = CompareStatus.SizeDoNotMatch
            };
        }

        private DiffingCompareResponse ContentNotMatchResponse(ICollection<Diff> diffs)
        {
            return new()
            {
                DiffResultType = CompareStatus.ContentDoNotMatch,
                Diffs = diffs
            };
        }

        private DiffingCompareResponse EqualsResponse()
        {
            return new()
            {
                DiffResultType = CompareStatus.Equals
            };
        }
    }
}
