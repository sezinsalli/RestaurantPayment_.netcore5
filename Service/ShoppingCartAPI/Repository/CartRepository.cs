using AutoMapper;
using ShoppingCartAPI.DbContexts;
using ShoppingCartAPI.Models.Dtos;
using System.Threading.Tasks;

namespace ShoppingCartAPI.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;

        public CartRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public Task<bool> ClearCart(string userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<CartDto> CreateUpdateCart(CartDto cartDto)
        {
            throw new System.NotImplementedException();
        }

        public Task<CartDto> GetCartByUserId(string userId)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> RemoveFromCart(int cartDetailsId)
        {
            throw new System.NotImplementedException();
        }
    }
}
