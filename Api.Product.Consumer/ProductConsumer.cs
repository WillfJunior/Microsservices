using MassTransit;
using Shared.Model;

public class ProductConsumer : IConsumer<Product>
{
    public async Task Consume(ConsumeContext<Product> context)
    {
        using (var sw = new StreamWriter("Procut.txt"))
        {
            sw.WriteLine($"Product {context.Message.Name}, Price {context.Message.Price}");
        }
        await Console.Out.WriteLineAsync(context.Message.Name);
    }
}