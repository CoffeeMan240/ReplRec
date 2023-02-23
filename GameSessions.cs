using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class GameSessions
    {
        public static Presence GetPresenceForPid(string pid)
        {
            return new Presence()
            {
                GameSession = JsonConvert.DeserializeObject<GameSession>(File.ReadAllText(Program.DataPath + Program.d + pid + "presence.json")),
                InScreenMode = true,
                IsOnline = true,
                PlayerId = int.Parse(pid)
            };
        }
    }
    public class Presence
    {
        public int PlayerId { get; set; }
        public bool IsOnline { get; set; }
        public bool InScreenMode { get; set; }
        public GameSession GameSession { get; set; }
    }
    public class GameSession
    {
        public int GameSessionId { get; set; }
        public string RegionId { get; set; }
        public string RoomId { get; set; }
        public int? EventId { get; set; }
        public int? RecRoomId { get; set; }
        public int? CreatorPlayerId { get; set; }
        public string Name { get; set; }
        public string ActivityLevelId { get; set; }
        public bool Private { get; set; }
        public bool Sandbox { get; set; }
        public bool SupportsVR { get; set; }
        public bool SupportsScreens { get; set; }
        public bool GameInProgress { get; set; }
        public int MaxCapacity { get; set; }
        public bool IsFull { get; set; }

    }
    public class RegionPing
    {
        public string Region { get; set; }
        public int Ping { get; set; }
    }
    public class JoinRandom
    {
        public string[] ActivityLevelIds { get; set; }
        public int[] ExpectedPlayerIds { get; set; }
        public RegionPing[] RegionPings { get; set; }
    }
    public class JoinResult
    {
        public int Result { get; set; }
        public GameSession GameSession { get; set; }
    }

}
