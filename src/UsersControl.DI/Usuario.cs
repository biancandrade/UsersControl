using System;

namespace UsersControl.DI
{
    public class Usuario
    {
        public string Nome { get; set; }
        public int Senha { get; set; }
        public DateTime DataCadastro { get; set; }
        public PerfilEnum Perfil { get; set; }
        public StatusEnum Status { get; set; }

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
                throw new Exception("Data de Cadastro do usuario é obrigatória.");
            }
        }

        public void AtribuirPerfil(PerfilEnum perfil)
        {
            Perfil = perfil;
        }

        public void AtribuirStatus(StatusEnum status)
        {
            Status = status;
        }
    }
}
