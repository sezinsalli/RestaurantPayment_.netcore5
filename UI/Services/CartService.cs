﻿using System.Net.Http;
using System.Threading.Tasks;
using UI.Models;
using UI.Services.IServices;

namespace UI.Services
{
    public class CartService : BaseService, ICartService
    {
        private readonly IHttpClientFactory _clientFactory;

        public CartService(IHttpClientFactory clientFactory) : base(clientFactory)
        {
            _clientFactory = clientFactory;
        }

        public async Task<T> AddToCartAsync<T>(CartDto cartDto)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType=SD.ApiType.POST,
                Data = cartDto,
                Url=SD.ShoppingCartAPIBase+"/api/cart/AddCart",
                AccessToken=""

            });
        }


        public async Task<T> GetCartByUserIdAsync<T>(string userId)
        {
            return await this.SendAsync<T>(new ApiRequest
            {
                ApiType=SD.ApiType.GET,
                Url=SD.ShoppingCartAPIBase+"/api/cart/GetCart/"+userId,
                AccessToken=null
            });
        }

        public Task<T> GetCartByUserIdAsync<T>(string userId, string token = null)
        {
            throw new System.NotImplementedException();
        }

        public async Task<T> RemoveFromCartAsync<T>(int CartId, string token = null)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = CartId,
                Url = SD.ShoppingCartAPIBase + "/api/cart/RemoveCart",
                AccessToken = token
            });
        }


        public async Task<T> UpdateCartAsync<T>(CartDto cartDto, string token = null)
        {
            return await this.SendAsync<T>(new ApiRequest()
            {
                ApiType = SD.ApiType.POST,
                Data = cartDto,
                Url = SD.ShoppingCartAPIBase + "/api/cart/UpdateCart",
                AccessToken = token
            });
        }
    }
}
