using Microsoft.Extensions.DependencyInjection;
using HotelProject.BusinessLayer.Abstract;
using HotelProject.BusinessLayer.Concrete;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.EntityFramework;

namespace HotelProject.WebAPI
{
    public static class AddDl
    {
 
        public static IServiceCollection AddDI(this IServiceCollection services)
        {
            services.AddDbContext<Context>();

            services.AddScoped<IStaffDal, EfStaffDal>();
            services.AddScoped<IStaffService, StaffManager>();

            services.AddScoped<IServicesDal, EfServiceDal>();
            services.AddScoped<IServiceService, ServiceManager>();

            services.AddScoped<IRoomDal, EfRoomDal>();
            services.AddScoped<IRoomService, RoomManager>();

            services.AddScoped<ISubscribeDal, EfSubscribeDal>();
            services.AddScoped<ISubscribeService, SubscribeManager>();

            services.AddScoped<ITestimonialDal, EfTestimonialDal>();
            services.AddScoped<ITestimonialService, TestimonialManager>();

            services.AddScoped<IAboutDal, EfAboutDal>();
            services.AddScoped<IAboutService, AboutManager>();

            services.AddScoped<IBookingDal, EfBookingDal>();
            services.AddScoped<IBookingService, BookingManager>();

            return services;
        }
    }
}
