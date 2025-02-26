using do_not_do_alone_practice.Server.Models;

namespace do_not_do_alone_practice.Server.Interfaces
{
    public interface IFriendRepository
    {
        List<Friend> GetAllFriends();
        Friend GetFriendById(int id);
        Friend AddFriend(Friend friend);
        Friend UpdateFriend(Friend friend);
        void DeleteFriend(int id);
    }
}
