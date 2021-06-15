using LoginSharp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginSharp.Modelo
{
    class Controle
    {
        public bool tem;
        public string mensagem = "";
        public bool acessar(string login, string senha)
        {
            loginDaoComandos loginDao = new loginDaoComandos();
            tem = loginDao.Verificausuario(login, senha);
            if (!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }
        public string cadastrar(string email, string senha, string confSenha)
        {
            loginDaoComandos loginDao = new loginDaoComandos();
            this.mensagem = loginDao.CadastrarUsuario(email, senha, confSenha);
            if (loginDao.tem)
            {
                this.tem = true;
            }
            return mensagem;
        }
    }
}
