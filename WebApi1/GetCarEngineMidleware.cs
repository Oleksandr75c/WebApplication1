using System;

namespace WebApi1
{
    public class GetCarEngineMidleware
    {

        private readonly RequestDelegate requestDelegate;
        public GetCarEngineMidleware(RequestDelegate requestDelegate)
        { 
            this.requestDelegate = requestDelegate;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var carBd = new CarBD();
            IManagementCars mc = new ManagementCars();

            var gce = context.Request.Query["CarEngine"];
            if (gce.Count != 0)
            {
                var result = mc.GetCarEngine(Convert.ToInt32(gce), carBd.cars);
                if (result.Count > 0)
                {
                    await context.Response.WriteAsync($" Was found next cars with parametr CarEngine = {gce}:");
                    foreach (var car in result) 
                    await context.Response.WriteAsync($"\n Manufacturer: {car.manufacturer},   Model: {car.model},  Year manufactured: {car.yearManufacture} ");
                }
                else await context.Response.WriteAsync($"\n Nothing found for request CarEngine = {gce}");
            }
            else  await requestDelegate.Invoke(context);
        }


    }
}



