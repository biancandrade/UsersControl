using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UsersControl.DI
{
    public interface IUsuarioRepositorio
    {
        Usuario Inserir(Usuario usuario);

        void Excluir(Usuario usuario);
    }
}
