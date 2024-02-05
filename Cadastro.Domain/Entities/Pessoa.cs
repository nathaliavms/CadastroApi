
namespace Cadastro.Domain.Entities
{
    public class Pessoa
    {
        private Guid id;
        public Guid Id 
        {
            get => id == Guid.Empty ?
                NewPessoa() : id;
            
            set => id = value;
        
        }
        public string? Name { get; set; }

        private Guid NewPessoa() 
        {
            id = Guid.NewGuid();
            return id;
        }
    }
}
