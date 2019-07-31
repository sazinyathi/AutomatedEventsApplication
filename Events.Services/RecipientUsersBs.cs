using Events.BLL.Interfaces;
using Events.BOL;
using Events.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Events.BLL
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
