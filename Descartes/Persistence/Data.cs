using Descartes.Domain;

namespace Descartes.Persistence
{
    public class Data
    {
        public int Id { get; set; }
        public byte[] Content { get; set; }
        public PositionStatus Position { get; set; }

        public IEnumerable<DataPair> PairedToAsFirst { get; set; }
        public IEnumerable<DataPair> PairedToAsSecond { get; set; }
    }
}
