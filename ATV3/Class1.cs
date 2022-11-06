using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATV03
{
    internal class Aluno
    {
        private string nome;
    private int matricula;
    public string email;

    public Aluno(string nome)
    {
        this.nome = nome;
    }

    public Aluno()
    {
    }

    public Aluno(string nome, int matricula, string email)
    {
        this.nome = nome;
        this.matricula = matricula;
        this.email = email;
    }


    // get e set nome
    public string getNome()
    {
        return this.nome;
    }

    public void setNome(string nome)
    {
        this.nome = nome;
    }

    // get e set matricula
    public int getMatricula()
    {
        return this.matricula;
    }

    public void setMatricula(int matricula)
    {
        this.matricula = matricula;
    }

    // get e set email
    public string getEmail()
    {
        return this.email;
    }

    public void setEmail(string email)
    {
        this.nome = email;
    }

    public void imprimir()
    {
        Console.WriteLine(this.nome + " " + this.matricula + " " + this.email);
    }


}




