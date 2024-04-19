using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    internal class Product
    {
        /*
        Nel progetto csharp-oop-shop, creare la classe Prodotto che gestisce i prodotti dello shop.
        Un prodotto è caratterizzato da:
        - codice (numero intero)
        - nome
        - descrizione
        - prezzo
        - iva
        Usate opportunamente i livelli di accesso (public, private), i costruttori,
        i metodi getter e setter ed eventuali altri metodi di “utilità” per fare in modo che:
        alla creazione di un nuovo prodotto il codice sia valorizzato con un numero random
        Il codice prodotto sia accessibile solo in lettura
        Gli altri attributi siano accessibili sia in lettura che in scrittura
        Il prodotto esponga sia un metodo per avere il prezzo base che uno per avere il prezzo comprensivo di iva
        Il prodotto esponga un metodo per avere il nome esteso, ottenuto concatenando codice + nome
        Testate poi i vostri oggetti Prodotto, istanziandoli e provando ad interargirci per testare tutti i metodi che avete previsto
        */
        private int _code;
        public int Code
        {
            get { return _code; }
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal IVA { get; set; }

        public Product(string name, string description, decimal price, decimal iva)
        {
            _code = CodeGeneration();
            Name = name;
            Description = description;
            Price = price;
            IVA = iva;
        }

        private int CodeGeneration()
        {
            Random rnd = new Random();
            return rnd.Next(10000, 99999);
        }


    }
}
