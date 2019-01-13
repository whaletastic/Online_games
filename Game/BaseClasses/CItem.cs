﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Game.BaseClasses
{
    public class CItemDescription
    {
        public CItemDescription(int id, string name, string description, string picture)
        {
            if (GItemsList.ItemsList.ContainsKey(id))
            {
                throw new Exception("Item already exist");
            }
            Id = id;
            Name = name;
            Description = description;
            Picture = picture;
            GItemsList.Add(this);
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
    }
    public class CItemInventory
    {
        
        public CItemInventory(int id, int rang)
        {
            Id = id;
            Rang = rang;
            Count = 1;
        }

        public CItemDescription Description()
        {
            return GItemsList.Get(this.Id);
        }
        public int Id { get; set; }
        public int Rang { get; set; }
        public int Count { get; set; }
    }

}