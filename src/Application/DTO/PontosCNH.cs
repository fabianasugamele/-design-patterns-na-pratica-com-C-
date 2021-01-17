using System;

namespace Application.DTO
{
    [Serializable]

    public class PontosCNH
    {
        public DateTime DataOcorrencia { get; set; }
        public string Descricao { get; set; }
        public int Total { get; set; }
    }
}