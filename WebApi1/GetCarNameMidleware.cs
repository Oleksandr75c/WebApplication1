using System;

namespace WebApi1
{
    public class GetCarNameMidleware
    {
        private readonly RequestDelegate requestDelegate;
        public GetCarNameMidleware(RequestDelegate requestDelegate)
        { 
            this.requestDelegate = requestDelegate;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var carBd = new CarBD();
            IManagementCars mc = new ManagementCars();

            var gcn = context.Request.Query["CarName"];
            if (gcn.Count != 0)
            {
                var result = mc.GetCarName(gcn, carBd.cars);
                if (result.Count > 0)
                {
                    await context.Response.WriteAsync($" Was found next cars  with parametr CarName = {gcn}:");
                    foreach (var car in result) 
                    await context.Response.WriteAsync($"\n Manufacturer: {car.manufacturer},   Model: {car.model},  Year manufactured: {car.yearManufacture} ");
                }
                else await context.Response.WriteAsync($"\n Nothing found for request CarName = {gcn}");
            }
            else  await requestDelegate.Invoke(context);
        }
    }
}



