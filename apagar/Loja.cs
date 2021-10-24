using System;
using System.Collections;
public class Loja{
    private int id{get;set;}
    ArrayList produtos = new ArrayList(); 
    public void adicionaProduto(Produto produto){
        produtos.Add(produto);
    }
    public ArrayList getprodutos() {
        return produtos;
    }




}
