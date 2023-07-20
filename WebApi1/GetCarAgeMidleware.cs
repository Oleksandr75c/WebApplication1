namespace WebApi1
{
    public class GetCarAgeMidleware
    {

        private readonly RequestDelegate requestDelegate;
        public GetCarAgeMidleware(RequestDelegate requestDelegate)
        { 
            this.requestDelegate = requestDelegate;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var carBd = new CarBD();
            IManagementCars mc = new ManagementCars();

            var gca = context.Request.Query["CarAge"];
            if (gca.Count != 0)
            {
                var result = mc.GetCarAge(Convert.ToInt32(gca), carBd.cars);
                if (result.Count > 0)
                {
                    await context.Response.WriteAsync($" Was found {gca} years old cars:");
                    foreach (var car in result)
                        await context.Response.WriteAsync($"\n Manufacturer: {car.manufacturer},   Model: {car.model},  Year manufactured: {car.yearManufacture} ");
                }
                else await context.Response.WriteAsync($"\n Nothing found for request CarAge = {gca}");
            }
            else
            {
                await context.Response.WriteAsync($"\n Nothing found");
               // await requestDelegate.Invoke(context);
            }
        }


    }
}



