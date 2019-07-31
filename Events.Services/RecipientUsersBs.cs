using Events.DAL.Interfaces;
using Events.Models;
using Events.Services.Interfaces;

namespace Events.Services
{
    public class RecipientUsersBs : IRecipientUsers
    {
        IRecipientUsersRepository recipientUsersRepository;
        public RecipientUsersBs(IRecipientUsersRepository recipientUsersRepository)
        {
            this.recipientUsersRepository = recipientUsersRepository;
        }
        public void CreateRecipientUsersRepository(ReciepentsUsers reciepentsUsers)
        {
            recipientUsersRepository.CreateRecipientUsersRepository(reciepentsUsers);
        }
    }
}
