
using System;
using NUnit.Framework;
using UsersControl;
using UsersControl.DI;

namespace UsersControlTest
{
    [TestFixture]
    public class UsersTest
    {

        [Test] 
        public void Deve_Existir_Usuario()
        {
            var usuario = new Usuario();
            Assert.Pass();
        }

        [Test]
        public void Todo_Usuario_Deve_Ter_Nome()
        {
            var usuario = new Usuario();

            usuario.Nome = "Bianca";

            Assert.AreEqual(usuario.Nome, "Bianca");
        }

        [Test]
        public void Todo_Usuario_Deve_Ter_Senha()
        {
            var usuario = new Usuario();
            usuario.Senha = 123456;
            Assert.AreEqual(usuario.Senha, 123456);
        }        

        [Test]
        public void Nome_Do_Usuario_Deve_Ser_Preenchido()
        {
            var usuario = new Usuario();

            usuario.Nome = "Bianca";
            usuario.VerificarSeNomeEhVazio();

            Assert.Pass();
        }

        [Test]
        public void Nome_Do_Usuario_Nao_Pode_Ser_Nulo_Nem_Vazio()
        {
            var usuario = new Usuario();

            usuario.Nome = null;
            usuario.Nome = "";

            Assert.Throws<Exception>(usuario.VerificarSeNomeEhVazio, "Nome do Usuario é obrigatório.");
        }

        [Test] public void Todo_Usuario_Deve_Ter_Data_De_Cadastro()
        {
            var usuario = new Usuario();

            usuario.DataCadastro = DateTime.Now;

            Assert.Pass();
        }

        [Test]
        public void Todo_Usuario_Deve_Ter_Status()
        {
            var usuario = new Usuario();
            usuario.Status = StatusEnum.Desbloqueado;
            Assert.Pass();
        }

        [Test]
        public void Data_De_Cadastro_Do_Usuario_Nao_Pode_Ser_Nulo()
        {
            var usuario = new Usuario();

            Assert.Throws<Exception>(usuario.VerificarSeDataEhNula, "Data de Cadastro do usuario é obrigatório.");
        }

        [Test]
        public void Deve_Permitir_Criar_Um_Perfil()
        {
            var perfil = new PerfilEnum();
            Assert.Pass();
        }

        [Test]
        public void Posso_Adicionar_Perfil_Ao_Usuario()
        {
            var usuario = new Usuario
                              {
                                Nome = "Bianca",
                                DataCadastro = DateTime.Now,
                                Senha = 123456,
                                Status = StatusEnum.Desbloqueado,
                                Perfil = PerfilEnum.Administrador,
                              };
            
            usuario.AtribuirPerfil(usuario.Perfil);

            Assert.AreEqual(usuario.Perfil, PerfilEnum.Administrador);
        }

        [Test]
        public void Administrador_Pode_Bloquear_Um_Usuario()
        {
           
        }

        [Test]
        public void Administrador_Pode_Excluir_Usuario()
        {
            
        }

    }
}
