using System.Linq;
using MessageAPI.Models;

namespace MessageAPI.Data
{
    public class DbInitializer
    {
        public static void Initialize(MessageContext context)
        {
            context.Database.EnsureCreated();
            if (context.Messages.Any()) return;
            for (var i = 0; i < 10; i++)
            {
                context.Messages.Add(new Message { Text = $"Test message {i}"});
            }
            context.SaveChanges();
        }
    }
}
