using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main
{
    internal class RepelRecManager
    {
        public string CreateAccount()
        {
            Player real = new Player()
            {
                Id = (ulong)new Random().Next(10000, 99999),
                DisplayName = "RepelRecUser",
                Username = "RepelRecUser#",
                CanReceiveInvites = false,
                AvoidJuniors = true,
                Bio = "sex",
                Developer = true,
                ForceJuniorImages = false,
                HasBirthday = true,
                JuniorProfile = false,
                Level = 24,
                PendingJunior = false,
                PlatformIds = new List<Platforms>()
                {
                    new Platforms()
                    {
                        Platform = 0,
                        PlatformId = 69
                    }
                },
                PlayerReputation = new Reputation()
                {
                    CheerCreative = 10,
                    CheerCredit = 10,
                    CheerGeneral = 10,
                    CheerGreatHost = 10,
                    CheerHelpful = 10,
                    CheerSportsman = 10,
                    SelectedCheer = 0,
                    SubscribedCount = 0,
                    SubscriberCount = 0,
                    Noteriety = 0,
                },
                ProfileImageName = "DefaultProfileImage.jpg",
                RegistrationStatus = 2,
                XP = 0

            };
            real.Username = real.Username + real.Id.ToString();
            File.WriteAllText(Program.DataPath + real.Id.ToString() + "presence.json", JsonConvert.SerializeObject(new GameSession()
            {
                ActivityLevelId = "",
                CreatorPlayerId = 1,
                MaxCapacity = 20,
                EventId = null,
                GameInProgress = false,
                GameSessionId = 6969420,
                IsFull = false,
                Name = "Test",
                Private = false,
                RecRoomId = null,
                RegionId = "us",
                RoomId = "",
                Sandbox = false,
                SupportsScreens = true,
                SupportsVR = true,
            });
        }
    }
    public class Player
    {
        public ulong Id { get; set; }
        public string Username { get; set; }
        public string DisplayName { get; set; }
        public string Bio { get; set; }
        public int XP { get; set; }
        public int Level { get; set; }
        public int RegistrationStatus { get; set; }
        public bool Developer { get; set; }
        public bool CanReceiveInvites { get; set; }
        public string ProfileImageName { get; set; }
        public bool JuniorProfile { get; set; }
        public bool ForceJuniorImages { get; set; }
        public bool PendingJunior { get; set; }
        public bool HasBirthday { get; set; }
        public bool AvoidJuniors { get; set; }
        public Reputation PlayerReputation { get; set; }
        public List<Platforms> PlatformIds { get; set; }
    }
    public class Reputation
    {
        public int Noteriety { get; set; }
        public int CheerGeneral { get; set; }
        public int CheerHelpful { get; set; }
        public int CheerGreatHost { get; set; }
        public int CheerSportsman { get; set; }
        public int CheerCreative { get; set; }
        public int CheerCredit { get; set; }
        public int SubscriberCount { get; set; }
        public int SubscribedCount { get; set; }
        public int SelectedCheer { get; set; }
    }
    public class Platforms
    {
        public long Platform { get; set; }
        public long PlatformId { get; set; }
    }
    public class Cached
    {
        public string Error { get; set; }
        public Player Player { get; set; }
        public string Token { get; set; }
        public bool FirstLoginOfTheDay { get; set; }
        public ulong AnalyticsSessionId { get; set; }
        public bool CanUseScreenMode { get; set; }
    }
