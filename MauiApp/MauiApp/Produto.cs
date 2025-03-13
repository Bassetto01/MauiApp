using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp
{
    internal class Produto
    {
        public double Preco { get; set; }

        public string Nome { get; set; }

        public string Categoria { get; set; }

        public static List<Produto> Lista 
        {
            get
             {  
                List<Produto> lista = new List<Produto>();
                lista.Add(new Produto(){Nome = "Laurinha", Preco = 250, Categoria = "Moça Da Noite"});
                lista.Add(new Produto() { Nome = "Estrela", Preco = 300, Categoria = "Moça Da Noite" });
                lista.Add(new Produto() { Nome = "Luna", Preco = 280, Categoria = "Moça Da Noite" });
                lista.Add(new Produto() { Nome = "Jasmim", Preco = 320, Categoria = "Moça Da Noite" });
                lista.Add(new Produto() { Nome = "Aurora", Preco = 270, Categoria = "Moça Da Noite" });
                return lista;
             }
            
        }
    }
}
