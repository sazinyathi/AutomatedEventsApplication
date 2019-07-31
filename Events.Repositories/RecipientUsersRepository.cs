using Events.DAL.Interfaces;
using Events.Models;

namespace Events.Repositories
{
    public class RecipientUsersRepository : IRecipientUsersRepository
    {
        EventsDbContext dbContext;
        public RecipientUsersRepository(EventsDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public void CreateRecipientUsersRepository(ReciepentsUsers reciepentsUsers)
        {
            dbContext.Add(reciepentsUsers);
            dbContext.SaveChanges();
        }
    }
}
