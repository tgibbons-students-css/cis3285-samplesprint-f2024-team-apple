namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        public MessageRecord(int roomID, string authorName, string text)
        {
            // "As a message reading user, I want to view a list of rooms that represent conversations."
            RoomID = roomID;
            Text = text;
            AuthorName = authorName;
        }

        public int RoomID
        {
            get;
            private set;
        }

        public string Text
        {
            get;
            private set;
        }

        public string AuthorName
        {
            // "As a message reading user, I want to view a list of rooms that represent conversations."
            get;
            private set;
        }
    }
}
