namespace Vacinacao.Core.Domain
{
    public class Agenda : IEntity
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Hora { get; set; }
        public string Situacao { get; set; }
        public DateTime DataSituacao { get; set; }
        public string Observacoes { get; set; }
        public Vacina Vacina { get; set; }
    }
}
