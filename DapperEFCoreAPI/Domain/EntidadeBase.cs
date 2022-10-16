namespace DapperEFCoreAPI.Domain
{
    public class EntidadeBase
    {
        public int Id { get; set; }

        public DateTime DataCadastro { get; set; }

        public DateTime? DataAlteracao { get; set; }

        public void SetCadastro()
        {
            DataCadastro = DateTime.Now;
        }

        public void SetAlteracao()
        {
            DataAlteracao = DateTime.Now;
        }
    }
}
