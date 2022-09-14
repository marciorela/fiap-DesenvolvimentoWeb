using fiapweb2022.Middlewares;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.Use(async (context, next) =>
//{
//    // LOGICA AQUI

//    await next.Invoke();

//    // LOGICA NO FINAL
//});

//app.Map("/admin", myapp =>
//{
//    myapp.Run(async context =>
//    {
//        await context.Response.WriteAsync("Area do admin");
//    });
//});

//app.MapWhen(context => context.Request.Query.ContainsKey("aluno"), myapp => {
//    myapp.Run(async context =>
//    {
//        await context.Response.WriteAsync("Parametro URL");
//    });
//});

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("FIAPAO");
//});

//app.UseMiddleware<MeuMiddleware>();

app.UseMeuMiddleware();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseRouting();

app.MapControllerRoute(
    name: "default1",
    pattern: "{controller=home}/{action=index}/{id?}"
);

app.MapControllerRoute(
    name: "default2",
    pattern: "{controller}/{action}/{id?}",
    defaults: new { controller = "home", action = "index" }
);



app.Run();

//app.MapGet("/", () => "Olá, boa noite");


