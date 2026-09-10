using Cloudflare.Workers.Hosting;

var builder = WorkerApplication.CreateBuilder();

builder.MapGet("/", static _ =>
    Task.FromResult(HttpResponse.Text("Hello from C# on Cloudflare Workers!")));

builder.MapGet("/delay/:ms", static async context =>
{
    double ms = Math.Min(double.Parse(context.Parameters["ms"]), 5000);
    await WorkerTimer.Delay(ms);
    return HttpResponse.Text($"Slept {ms} ms without blocking the isolate.");
});

builder.MapPost("/echo", static async context =>
    HttpResponse.Text(await context.Request.ReadAsStringAsync()));

builder.Build().Run();