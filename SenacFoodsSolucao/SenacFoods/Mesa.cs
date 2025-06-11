namespace SenacFoods
{
    public class Mesa
    {
        public int Id { get; set; }
        public int NumeroMesa { get; set; }
        // 0-Disponível 1-ocupada 2-Reservada
        public int SituacaoMesa { get; set; }
    }
}
