using MessageAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MessageAPI.Data
{
    public class MessageContext : DbContext
    {
        public DbSet<Message> Messages { get; set; }

        public MessageContext(DbContextOptions<MessageContext> options) : base(options)
        {
        }
    }
}
