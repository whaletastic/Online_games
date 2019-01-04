﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdminictratorProject.Game.UpdateClasses.Buildings;
using AdministratorProject.Game;
using AdministratorProject.Game.BaseClasses;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace AdministratorProject.Game.Locations
{
    public class CMetropolis: CLocation
    {
        /*
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<CLocation> SubLocations { get; set; } = new List<CLocation>();
        public List<LCMob> Mobs { get; set; } = new List<LCMob>();
        public List<LCItems> Collectibles { get; set; } = new List<LCItems>();
        public List<LCMob> LegendaryMobs { get; set; }
        public List<IBaseActions> Actions { get; set; }
        public List<IBaseActions> NeighboringLocs { get; set; }
        */
        CMetropolis(GInt counter):base(counter, "Метрополис")
        {
            Description = "Стартовый город для новичков";


        }
        public class Metropolis_Market : CMarket
        {
            public Metropolis_Market(GInt gInt, string name) : base(gInt, name)
            {
                Description = "Пока есть только торговец палками";

            }
        }
    }

    
}