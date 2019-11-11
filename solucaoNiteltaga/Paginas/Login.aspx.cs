using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using WebLogin.Classes;
using WebLogin.Persistencia;

public partial class Pages_Login : System.Web.UI.Page


{
    private bool IsPreenchido(string str)
    {
        bool retorno = false;
        if (str != string.Empty)
        {
            retorno = true;
        }
        return retorno;
    }

    private bool UsuarioEncontrado(Pessoa pessoa)
    {
        bool retorno = false;
        if (pessoa != null)
        {
            retorno = true;
        }
        return retorno;
    }

    protected void btnEntrar_Click(object sender, EventArgs e)
    {
        string email = txtNome.Text.Trim();
        string senha = txtCpf.Text.Trim();
        if (!IsPreenchido(email))
        {
            lblMensagem.Text = "Preencha o email";
            txtNome.Focus();
            return;
        }
        if (!IsPreenchido(senha))
        {
            lblMensagem.Text = "Preencha a senha";
            txtCpf.Focus();
            return;
        }
        PessoaBD bd = new PessoaBD();
        Pessoa pessoa = new Pessoa();
        pessoa = bd.Autentica(email, senha);
        if (!UsuarioEncontrado(pessoa))
        {
            lblMensagem.Text = "Usuário não encontrado";
            txtNome.Focus();
            return;
        }
        Session["ID"] = pessoa.Codigo;
        switch (pessoa.Tipo)
        {
            case 0:
                Response.Redirect("Pedido.aspx");
                break;
            case 1:
                Response.Redirect("Cliente/Index.aspx");
                break;
            default:
                break;
        }
        string nome = txtNome.Text.Trim();
        string cpf = txtCpf.Text.Trim();

        if (!IsPreenchido(nome))
        {
            lblMensagem.Text = "<a class='btn btn-danger' > Preencha o nome</a>";
            txtNome.Focus();
            return;
        }
        if (!IsPreenchido(cpf))
            lblMensagem.Text = "<a class='btn btn-danger' >Preencha o CPF </a>";
        txtCpf.Focus();
        return;
    }

    PessoaBD bd = new PessoaBD();
    Pessoa pessoa = new Pessoa();

    
    }
   




