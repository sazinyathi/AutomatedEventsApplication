using Events.BOL;
using Events.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.DAL
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
