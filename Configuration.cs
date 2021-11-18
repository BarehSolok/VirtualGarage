﻿using System.Collections.Generic;
using RFGarageClassic.Enums;
using RFGarageClassic.Models;
using Rocket.API;

namespace RFGarageClassic
{
    public class Configuration : IRocketPluginConfiguration
    {
        public bool Enabled;
        public EDatabase Database;
        public string MySqlConnectionString;
        public string MessageColor;
        public string AnnouncerIconUrl;
        public bool AutoClearDestroyedVehicles;
        public bool AutoAddOnDrown;
        public string AutoAddOnDrownPermission;
        public bool AllowTrain;
        public int DefaultGarageSlot;
        public string GarageSlotPermissionPrefix;
        public List<Blacklist> Blacklists;
        
        public void LoadDefaults()
        {
            Enabled = false;
            Database = EDatabase.LITEDB;
            MySqlConnectionString = "SERVER=127.0.0.1;DATABASE=unturned;UID=root;PASSWORD=123456;PORT=3306;TABLENAME=rfgarage;";
            MessageColor = "magenta";
            AnnouncerIconUrl = "https://i.imgur.com/3KlgN14.png";
            AutoClearDestroyedVehicles = true;
            AutoAddOnDrown = true;
            AutoAddOnDrownPermission = "garagedrown";
            AllowTrain = false;
            DefaultGarageSlot = 5;
            GarageSlotPermissionPrefix = "garageslot";
            Blacklists = new List<Blacklist>
            {
                new Blacklist
                {
                    Type = EBlacklistType.BARRICADE,
                    BypassPermission = "garagebypass.barricade.example",
                    IdList = new List<ushort> {1, 2}
                },
                new Blacklist
                {
                    Type = EBlacklistType.ITEM,
                    BypassPermission = "garagebypass.item.example",
                    IdList = new List<ushort> {1, 2}
                },
                new Blacklist
                {
                    Type = EBlacklistType.VEHICLE,
                    BypassPermission = "garagebypass.vehicle.example",
                    IdList = new List<ushort> {1, 2}
                },
                new Blacklist
                {
                    Type = EBlacklistType.BARRICADE,
                    BypassPermission = "garagebypass.barricade.example2",
                    IdList = new List<ushort> {3, 4}
                },
                new Blacklist
                {
                    Type = EBlacklistType.ITEM,
                    BypassPermission = "garagebypass.item.example2",
                    IdList = new List<ushort> {3, 4}
                },
                new Blacklist
                {
                    Type = EBlacklistType.VEHICLE,
                    BypassPermission = "garagebypass.vehicle.example2",
                    IdList = new List<ushort> {3, 4}
                },
            };
        }
    }
}