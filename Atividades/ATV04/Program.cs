﻿﻿using System;
using System.Collections.Generic;


public enum TipoLocalidade
{
    Rural,
    Urbano
}


public enum TipoNegocio
{
    Locacao,
    Venda
}


public enum Categoria
{
    Apartamento,
    Casa,
    Sitio
}


public class ItemImovel
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public decimal Valor { get; set; }
    public int NumeroComodos { get; set; }
    public List<string> Imagens { get; set; }
    public Categoria Categoria { get; set; }
    public TipoLocalidade TipoLocalidade { get; set; }
    public TipoNegocio TipoNegocio { get; set; }

    public ItemImovel(string nome, string descricao, decimal valor, int numeroComodos, Categoria categoria, TipoLocalidade tipoLocalidade, TipoNegocio tipoNegocio)
    {
        Nome = nome;
        Descricao = descricao;
        Valor = valor;
        NumeroComodos = numeroComodos;
        Imagens = new List<string>();
        Categoria = categoria;
        TipoLocalidade = tipoLocalidade;
        TipoNegocio = tipoNegocio;
    }
}


public class GerenciadorItens
{
    private List<ItemImovel> itens;

    public GerenciadorItens()
    {
        itens = new List<ItemImovel>();
    }

    
    public void AdicionarItem(ItemImovel item)
    {
        itens.Add(item);
    }

    
    public List<ItemImovel> BuscarItens(Categoria categoria, TipoLocalidade tipoLocalidade, TipoNegocio tipoNegocio)
    {
        return itens.FindAll(i => i.Categoria == categoria && i.TipoLocalidade == tipoLocalidade && i.TipoNegocio == tipoNegocio);
    }
}

class Program
{
    static void Main(string[] args)
    {
       
        GerenciadorItens gerenciador = new GerenciadorItens();

        
        gerenciador.AdicionarItem(new ItemImovel("Apartamento no centro", "Apartamento bem localizado", 200000, 3, Categoria.Apartamento, TipoLocalidade.Urbano, TipoNegocio.Venda));
        gerenciador.AdicionarItem(new ItemImovel("Casa no campo", "Casa com área verde", 300000, 4, Categoria.Casa, TipoLocalidade.Rural, TipoNegocio.Venda));
        gerenciador.AdicionarItem(new ItemImovel("Sitio para locação", "Sitio com piscina", 5000, 6, Categoria.Sitio, TipoLocalidade.Rural, TipoNegocio.Locacao));

        
        List<ItemImovel> resultados = gerenciador.BuscarItens(Categoria.Apartamento, TipoLocalidade.Urbano, TipoNegocio.Venda);
        foreach (var item in resultados)
        {
            Console.WriteLine($"Nome: {item.Nome}, Descrição: {item.Descricao}, Valor: {item.Valor}, Nro de Comodos: {item.NumeroComodos}");
        }
    }
}