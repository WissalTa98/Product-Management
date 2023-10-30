using app_Models;

namespace app_Client.Service.IService
{
	public interface IProductService
	{
		public Task<IEnumerable<ProductDTO>> GetAll();
		public Task<ProductDTO> Get(int productId);
	}
}
