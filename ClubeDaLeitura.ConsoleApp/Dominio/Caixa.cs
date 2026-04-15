using System;
using System.Dynamic;
using System.Security.Cryptography;

namespace ClubeDaLeitura.ConsoleApp.Dominio;

public class Caixa
{
    public string Id { get; set; } = string.Empty; // propriedade
    public string Etiqueta { get; set; } = string.Empty; // propriedade

    public string Cor { get; set; } = string.Empty;

    public int DiasDeEmprestimo { get; set; } = 7;

    // construtor de classe
    // toda instãncia que for criada PRECISA dessas informações  
    public Caixa(string etiqueta, string cor, int diasDeEmprestimo)
    {
        Id = Convert
            .ToHexString(RandomNumberGenerator.GetBytes(20))
            .ToLower()
            .Substring(0, 7);

        Etiqueta = etiqueta;
        Cor = cor;
        DiasDeEmprestimo = diasDeEmprestimo;
    }
}
