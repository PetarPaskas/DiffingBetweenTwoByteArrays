namespace Descartes.Persistence
{
    public class DataPair
    {
        public int Id { get; set; }
        public int? FirstId { get; set; }
        public int? SecondId { get; set; }
        public string PairingResult { get; set; }

        public Data First { get; set; }
        public Data Second { get; set; }
    }
}
