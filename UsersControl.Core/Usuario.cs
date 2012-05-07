using System;

namespace UsersControl.Core
{
    public class Usuario
    {
        public string Nome { get; set; }
        public int Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public Perfil Perfil { get; set; }

        public void VerificarSeNomeEhVazio()
        {
            if (string.IsNullOrWhiteSpace(Nome))
            {
                throw new Exception("Nome do usuario é obrigatório.");
            }
        }

        public void VerificarSeDataEhNula()
        {
            if (DataCadastro == DateTime.MinValue)
            {
                throw new Exception("Data de Cadastro do usuario é obrigatório.");
            }
        }
    }
}
