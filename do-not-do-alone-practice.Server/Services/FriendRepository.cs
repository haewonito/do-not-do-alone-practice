using do_not_do_alone_practice.Server.Interfaces;
using do_not_do_alone_practice.Server.Models;

namespace do_not_do_alone_practice.Server.Services
{
    public class FriendRepository : IFriendRepository
    {
        public static List<Friend> FriendList = new List<Friend>()
        {
            new Friend
            {
                Id = 1,
                FirstName = "John",
                LastName = "Morris",
                Email = "john.morris@example.com",
                Address = "123 Main St, Springfield, IL",
                Phone = "555-1234",
                Note = "This is a note about John.",
                PreferredContact = "email"
            },
            new Friend
            {
                Id = 2,
                FirstName = "Lizzy",
                LastName = "Keen",
                Email = "jane.smith@example.com",
                Address = "456 Oak St, Austin, TX",
                Phone = "555-5678",
                Note = "This is a note about Lizzy.",
                PreferredContact = "email"
            },
            new Friend
            {
                Id = 3,
                FirstName = "Joe",
                LastName = "Brown",
                Email = "joe.brown@example.com",
                Address = "789 Pine St, Denver, CO",
                Phone = "555-9012",
                Note = "This is a note about Joe.",
                PreferredContact = "email"
            },
            new Friend
            {
                Id = 4,
                FirstName = "Emily",
                LastName = "Johnson",
                Email = "emily.johnson@example.com",
                Address = "101 Maple Ave, Seattle, WA",
                Phone = "555-3456",
                Note = "This is a note about Emily.",
                PreferredContact = "email"
            },
            new Friend
            {
                Id = 5,
                FirstName = "Michael",
                LastName = "Williams",
                Email = "michael.williams@example.com",
                Address = "202 Birch Rd, Miami, FL",
                Phone = "555-7890",
                Note = "This is a note about Michael.",
                PreferredContact = "email"
            }

        };
        public Friend AddFriend(Friend friend)
        {
            FriendList.Add(friend);
            return friend;
        }

        public void DeleteFriend(int id)
        {
            FriendList.RemoveAt(id);
        }

        public List<Friend> GetAllFriends()
        {
            return FriendList;
        }

        public Friend GetFriendById(int id)
        {
            return FriendList.Find( x => x.Id == id );
        }

        public Friend UpdateFriend(Friend friend)
        {
            FriendList[friend.Id] = friend;
            return friend;
        }
    }
}
