using ProvaPub.Models;
using ProvaPub.Repository;

namespace ProvaPub.Services
{
	public class ProductService
	{
		TestDbContext _ctx;

		public ProductService(TestDbContext ctx)
		{
			_ctx = ctx;
		}

		public ProductList  ListProducts(int page)
		{
			int pageItens = 10;
			int index = (page - 1) * pageItens;
			var product = _ctx.Products.Skip(index).Take(pageItens).ToList();

			int totalCount = _ctx.Products.Count();
			bool hasNext = (index + pageItens) < totalCount;

			return new ProductList() {  HasNext=hasNext,TotalCount = totalCount, Products = product };
		}

	}
}
