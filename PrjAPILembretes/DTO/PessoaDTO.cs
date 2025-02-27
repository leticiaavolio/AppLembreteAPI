namespace PrjAPILembretes.DTO
{
    public class PessoaDTO
    {
        public string ?NomePessoa { get; set; } //o nome dos atributos não precisam ser o mesmo da model e do banco. e são parte da documentação

        public int IdadePessoa { get; set; }
    }
}
