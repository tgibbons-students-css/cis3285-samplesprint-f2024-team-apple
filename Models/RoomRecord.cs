namespace CIS3285_Unit3Sample_2024.Models
{
    public class RoomRecord
    {

        //As a message posting user, I want to create rooms for categorizing conversations -- Miles L


        public RoomRecord(string name, int roomId)
        {
            Name = name;
            RoomId1 = roomId;
        }

        int RoomId;
        public int RoomId1 { get => RoomId; set => RoomId = value; }

        public string Name
        {
            get;
            private set;
        }
    }
}
