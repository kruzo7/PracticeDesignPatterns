namespace DesignPatterns.Behavioral.Mediator;

class User
{
    private IChatRoomMediator mChatRoom;
    private string mName;

    public User(string name, IChatRoomMediator chatRoom)
    {
        mChatRoom = chatRoom;
        mName = name;
    }

    internal object GetName()
    {
        return mName;
    }

    public void Send(string message)
    {
        mChatRoom.ShowMessage(this, message);
    }
}
