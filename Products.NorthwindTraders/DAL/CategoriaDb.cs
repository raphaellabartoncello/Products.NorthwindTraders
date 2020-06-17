using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Products.NorthwindTraders.Models;

namespace Products.NorthwindTraders.DAL
{
    public class CategoriaDb
    {
        // CategoriasLista
        // Retorna a lista de Categorias
        //
        //
        public List<Categoria> CategoriasLista()
        {
            using (var db = new NorthwindContext())
            {
                return db.Categorias.ToList();
            }
        }
    }

    //Produtos por Categoria
    // retorna uma lista de produtos de uma categoria
    //
    public List<Produto> ProdutosPorCategoria(int categoriaId)
    {
        using (var db = new NorthwindContext())
        {
            var query = from c in db.Produtos
                        where c.CategoriaId == categoriaId
                        select c;
            var lista = query.ToList();

            return lista;
        }
    }

    // CategoriaObter
    // retorna uma categoria a partir do Id
    //
    public Categoria CategoriaObter(int id)
    {
        using (var db = new NorthwindContext())
        {
            return db.Categorias
           .Where(m => m.CategoriaId == id).FirstOrDefault();
        }
    }
}