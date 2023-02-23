using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace kutivault.API
{
    internal class Config
    {
        public static string GetConfig(bool NeedUpdate)
        {
            
            ConfData config = new ConfData()
            {
                MessageOfTheDay = "uwu <3",
                CdnBaseUri = "http://localhost:2000/",
                ShareBaseUrl = "http://localhost:2000/",
                LevelProgressionMaps = new List<LevelMap>()
                {
                    new LevelMap
                    {
                        Level = 0,
                        RequiredXp = 0

                    },
                    new LevelMap
                    {
                        Level = 1,
                        RequiredXp = 10

                    },
                    new LevelMap
                    {
                        Level = 2,
                        RequiredXp = 10

                    },
                    new LevelMap
                    {
                        Level = 3,
                        RequiredXp = 20

                    },
                    new LevelMap
                    {
                        Level = 4,
                        RequiredXp = 20

                    },
                    new LevelMap
                    {
                        Level = 5,
                        RequiredXp = 30

                    },
                    new LevelMap
                    {
                        Level = 6,
                        RequiredXp = 30

                    },
                    new LevelMap
                    {
                        Level = 7,
                        RequiredXp = 40

                    },
                    new LevelMap
                    {
                        Level = 8,
                        RequiredXp = 40

                    },
                    new LevelMap
                    {
                        Level = 9,
                        RequiredXp = 45

                    },
                    new LevelMap
                    {
                        Level = 10,
                        RequiredXp = 50

                    },
                    new LevelMap
                    {
                        Level = 11,
                        RequiredXp = 50

                    },
                    new LevelMap
                    {
                        Level = 12,
                        RequiredXp = 60

                    },
                    new LevelMap
                    {
                        Level = 13,
                        RequiredXp = 60

                    },
                    new LevelMap
                    {
                        Level = 14,
                        RequiredXp = 70

                    },
                    new LevelMap
                    {
                        Level = 15,
                        RequiredXp = 70

                    },
                    new LevelMap
                    {
                        Level = 16,
                        RequiredXp = 80

                    },
                    new LevelMap
                    {
                        Level = 17,
                        RequiredXp = 80

                    },
                    new LevelMap
                    {
                        Level = 18,
                        RequiredXp = 90

                    },
                    new LevelMap
                    {
                        Level = 19,
                        RequiredXp = 90

                    },
                    new LevelMap
                    {
                        Level = 20,
                        RequiredXp = 100

                    },
                    new LevelMap
                    {
                        Level = 21,
                        RequiredXp = 100

                    },
                    new LevelMap
                    {
                        Level = 22,
                        RequiredXp = 110

                    },
                    new LevelMap
                    {
                        Level = 23,
                        RequiredXp = 110

                    },
                    new LevelMap
                    {
                        Level = 24,
                        RequiredXp = 120

                    },
                    new LevelMap
                    {
                        Level = 25,
                        RequiredXp = 120

                    },
                    new LevelMap
                    {
                        Level = 26,
                        RequiredXp = 130

                    },
                    new LevelMap
                    {
                        Level = 27,
                        RequiredXp = 130

                    },
                    new LevelMap
                    {
                        Level = 28,
                        RequiredXp = 140

                    },
                    new LevelMap
                    {
                        Level = 29,
                        RequiredXp = 140

                    },
                    new LevelMap
                    {
                        Level = 30,
                        RequiredXp = 150

                    },
                },
                MatchmakingParams = new MatchPrams
                {
                    PreferEmptyRoomsFrequency = 0f,
                    PreferFullRoomsFrequency = 1f
                },
                ServerMaintainence = new ServerMaintainence
                {
                    StartsInMinutes = 0
                },
                DailyObjectives = new Objective[][]
                {
                    new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            },
            new Objective[]
            {
                new Objective
                {
                    type = 32,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            },
            new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            },
            new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            },
            new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            },
            new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            },
            new Objective[]
            {
                new Objective
                {
                    type = 20,
                    score = 1
                },
                new Objective
                {
                    type = 21,
                    score = 1
                },
                new Objective
                {
                    type = 22,
                    score = 1
                }
            }
        },
                ConfigTable = new List<CTable>
                {
                    new CTable
                    {
                        Key = "Gift.DropChance",
                        Value = 0.5f.ToString()
                    },
                    new CTable
                    {
                        Key = "Gift.Xp",
                        Value = 0.5f.ToString()
                    }
                },
                PhotonConfig = new PhotonConfig
                {
                    CloudRegion = "us",
                    CrcCheckEnabled = true,
                    EnableServerTracingAfterDisconnect = true
                },
                AutoMicMutingConfig = new AutoMicMutingConfig()
                {
                    MicSpamVolumeThreshold = 10,
                    MicSpamSamplePercentageForForceMute = 500,
                    MicSpamSamplePercentageForForceMuteToEnd = 0,
                    MicSpamSamplePercentageForWarning = 100,
                    MicSpamSamplePercentageForWarningToEnd = 0,
                    MicSpamWarningStateVolumeMultiplier = 10,
                    MicVolumeSampleInterval = 1,
                    MicVolumeSampleRollingWindowLength = 15,
                }





            };
            if (NeedUpdate)
            {
                config.ServerMaintainence.StartsInMinutes = 1;
            }
            return JsonConvert.SerializeObject(config);
        }
        public static string CohortNux()
        {
            return JsonConvert.SerializeObject(new List<CohortNUX>
            {
                new CohortNUX
                {
                    ButtonNumber = 0,
                    CustomRoomName = "RecCenter",
                    CustomTitle = "MORB WITH FRIENDS",
                    DefaultRoomName = "Paintball",
                    DefaultTitle = "PVP",
                    Override = 1,
                    Version = 1
                },
                new CohortNUX
                {
                    ButtonNumber = 1,
                    CustomRoomName = "RecCenter",
                    CustomTitle = "MORB WITH FRIENDS",
                    DefaultRoomName = "DormRoom",
                    DefaultTitle = "Button",
                    Override = 0,
                    Version = 2
                },
                new CohortNUX
                {
                    ButtonNumber = 2,
                    CustomRoomName = "RecCenter",
                    CustomTitle = "MORB WITH FRIENDS",
                    DefaultRoomName = "RecCenter",
                    DefaultTitle = "Button",
                    Override = 0,
                    Version = 3
                },
                new CohortNUX
                {
                    ButtonNumber = 3,
                    CustomRoomName = "RecCenter",
                    CustomTitle = "MORB WITH FRIENDS",
                    DefaultRoomName = "Basement",
                    DefaultTitle = "Button",
                    Override = 0,
                    Version = 4
                }
            });
        }
    }
    public class ConfData
    {
        public string MessageOfTheDay { get; set; }
        public string CdnBaseUri { get; set; }
        public string ShareBaseUrl { get; set; }
        public List<LevelMap> LevelProgressionMaps { get; set; }
        public MatchPrams MatchmakingParams { get; set; }
        public ServerMaintainence ServerMaintainence { get; set; }
        public Objective[][] DailyObjectives { get; set; }
        public List<CTable> ConfigTable { get; set; }
        public PhotonConfig PhotonConfig { get; set; }
        public AutoMicMutingConfig AutoMicMutingConfig { get; set; }

    }
    public class LevelMap
    {
        public int Level { get; set; }
        public int RequiredXp { get; set; }
    }
    public class MatchPrams
    {
        public float PreferFullRoomsFrequency { get; set; }
        public float PreferEmptyRoomsFrequency { get; set; }
    }
    public class Objective
    {
        public int type { get; set; }
        public int score { get; set; }
    }
    public class CTable
    {
        public string Key { get; set; }
        public string Value { get; set; }
    }
    public class PhotonConfig
    {
        public string CloudRegion { get; set; }
        public bool CrcCheckEnabled { get; set; }
        public bool EnableServerTracingAfterDisconnect { get; set; }
    }
    public class ServerMaintainence
    {
        public int StartsInMinutes { get; set; }
    }
    public class AutoMicMutingConfig
    {
        public double MicSpamVolumeThreshold { get; set; }
        public double MicVolumeSampleInterval { get; set; }
        public double MicVolumeSampleRollingWindowLength { get; set; }
        public double MicSpamSamplePercentageForWarning { get; set; }
        public double MicSpamSamplePercentageForWarningToEnd { get; set; }
        public double MicSpamSamplePercentageForForceMute { get; set; }
        public double MicSpamSamplePercentageForForceMuteToEnd { get; set; }
        public double MicSpamWarningStateVolumeMultiplier { get; set; }
    }
    public class CohortNUX
    {
        public int ButtonNumber { get; set; }
        public int Override { get; set; }
        public int Version { get; set; }
        public string CustomRoomName { get; set; }
        public string CustomTitle { get; set; }
        public string DefaultRoomName { get; set; }
        public string DefaultTitle { get; set; }
    }
    }

