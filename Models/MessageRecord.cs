namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        public MessageRecord(int roomID, string authorName, string text)
        {
            //Editing -- Miles L
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
            //Editing -- Miles L
            get;
            private set;
        }

        public string AuthorName
        {
            get;
            private set;
        }
    }
}
