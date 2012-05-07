
using System;
using NUnit.Framework;
using UsersControl;
using UsersControl.Core;

namespace UsersControlTest
{
    [TestFixture]
    public class UsersTest
    {

        [Test] public void Deve_Existir_Usuario()
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
        public void Data_De_Cadastro_Do_Usuario_Nao_Pode_Ser_Nulo()
        {
            var usuario = new Usuario();

            Assert.Throws<Exception>(usuario.VerificarSeDataEhNula, "Data de Cadastro do usuario é obrigatório.");
        }

        [Test]
        public void Deve_Permitir_Criar_Um_Perfil()
        {
            var perfil = new Perfil();
            Assert.Pass();
        }

        //[Test]
        //public void Posso_Adicionar_Perfil_Administrador_Ao_Usuario()
        //{
        //    var usuario = new Usuario();
                        
        //    administrador. = "Administrador";
        //    usuario.AtribuirPerfil(administrador);

        //    Assert.AreEqual(administrador, usuario.Perfil);
        //    Assert.AreEqual("Administrador", administrador.Nome);
        //}
    }
}
