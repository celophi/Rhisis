﻿using System.ComponentModel.DataAnnotations.Schema;

namespace Rhisis.Database.Entities
{
    [Table("items")]
    public sealed class DbItem : DbEntity
    {        
        public int ItemId { get; set; }
        
        public int CharacterId { get; set; }
        
        public int ItemCount { get; set; }
        
        public int ItemSlot { get; set; }
        
        public int CreatorId { get; set; }
        
        public byte Refine { get; set; }
        
        public byte Element { get; set; }
        
        public byte ElementRefine { get; set; }

        public DbCharacter Character { get; set; }

        public DbItem()
        {
        }

        public DbItem(int itemId, int itemSlot)
            : this(itemId, itemSlot, 1)
        {
        }

        public DbItem(int itemId, int itemSlot, int itemCount)
            : this(itemId, itemSlot, itemCount, 0, 0, 0)
        {
        }

        public DbItem(int itemId, int itemSlot, int itemCount, byte refine)
            : this(itemId, itemSlot, itemCount, refine, 0, 0)
        {
        }

        public DbItem(int itemId, int itemSlot, int itemCount, byte refine, byte element, byte elementRefine)
        {
            this.ItemId = itemId;
            this.ItemSlot = itemSlot;
            this.ItemCount = itemCount;
            this.Refine = refine;
            this.Element = element;
            this.ElementRefine = elementRefine;
        }

        public override string ToString()
        {
            return $"Id: {this.ItemId} - slot: {this.ItemSlot} - x{this.ItemCount}";
        }
    }
}
