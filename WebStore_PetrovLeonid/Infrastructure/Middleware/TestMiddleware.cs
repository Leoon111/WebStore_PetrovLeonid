using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace WebStore_PetrovLeonid.Infrastructure.Middleware
{
    public class TestMiddleware
    {
        private readonly RequestDelegate _Next;

        public TestMiddleware(RequestDelegate Next) => _Next = Next;

        public async Task InvokeAsync(HttpContext context)
        {
            // Выполнить действия перед следующим этапом, звеном конвейера

            //await context.Response.WriteAsync("Hello word");

            await _Next(context);
            
            // Выполнить действия после того, как оставшаяся часть конвейера отработала
        }
    }
}
