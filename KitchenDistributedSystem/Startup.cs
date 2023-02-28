using KitchenDistributedSystem.DataAccess;
using KitchenDistributedSystem.Factory;
using Microsoft.EntityFrameworkCore;

namespace KitchenDistributedSystem
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddDbContext<OrderContext>(context => { context.UseInMemoryDatabase("OrderDb"); });
            services.AddTransient<IOrderFactory,OrderFactory>();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvc();
            app.UseRouting();
            app.UseHttpsRedirection();

        }
    }
}
