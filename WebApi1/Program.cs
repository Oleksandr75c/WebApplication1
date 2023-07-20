using WebApi1;

internal class Program
{
    private static void Main(string[] args)
    {
    var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

 /*       builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
*/
        var app = builder.Build();

        app.UseMiddleware<GetCarNameMidleware>();       // request      ?CarName=volksvagen or ?CarName=grandvitara
        app.UseMiddleware<GetCarEngineMidleware>();              // request      ?CarEngine=149
        app.UseMiddleware<GetCarAgeMidleware>();              // request      ?CarAge=8

        // Configure the HTTP request pipeline.
        /*       if (app.Environment.IsDevelopment())
               {
                   app.UseSwagger();
                   app.UseSwaggerUI();
               }

        //       app.UseHttpsRedirection();

       //        app.UseAuthorization();

               app.MapControllers();
       */
        app.Run();



}
}