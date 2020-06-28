// File:    Room.cs
// Author:  fmaster
// Created: Thursday, May 21, 2020 10:21:32 PM
// Purpose: Definition of Class Room

using System.Collections.Generic;

namespace Model.Rooms
{
    public class Room : Repository.IIdentifiable<uint>
    {
        private uint id;
        private RoomType type;
        private string name;

        public Room(RoomType type, string name, List<ItemCount> itemCount)
        {
            id = 0;
            this.type = type;
            this.name = name;
            this.itemCount = itemCount;
        }

        public Room(uint id, RoomType type, string name, List<ItemCount> itemCount)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.itemCount = itemCount;
        }

        public Room(Room room)
        {
            id = room.id;
            type = room.type;
            name = room.name;
            itemCount = room.itemCount;
        }

        public RoomType Type
        {
            get => type;
            set => type = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public System.Collections.Generic.List<ItemCount> itemCount;

        /// <summary>
        /// Property for collection of ItemCount
        /// </summary>
        /// <pdGenerated>Default opposite class collection property</pdGenerated>
        public System.Collections.Generic.List<ItemCount> ItemCount
        {
            get
            {
                if (itemCount == null)
                {
                    itemCount = new System.Collections.Generic.List<ItemCount>();
                }

                return itemCount;
            }
            set
            {
                RemoveAllItemCount();
                if (value != null)
                {
                    foreach (ItemCount oItemCount in value)
                    {
                        AddItemCount(oItemCount);
                    }
                }
            }
        }

        /// <summary>
        /// Add a new ItemCount in the collection
        /// </summary>
        /// <pdGenerated>Default Add</pdGenerated>
        public void AddItemCount(ItemCount newItemCount)
        {
            if (newItemCount == null)
            {
                return;
            }

            if (itemCount == null)
            {
                itemCount = new System.Collections.Generic.List<ItemCount>();
            }

            if (!itemCount.Contains(newItemCount))
            {
                itemCount.Add(newItemCount);
            }
        }

        /// <summary>
        /// Remove an existing ItemCount from the collection
        /// </summary>
        /// <pdGenerated>Default Remove</pdGenerated>
        public void RemoveItemCount(ItemCount oldItemCount)
        {
            if (oldItemCount == null)
            {
                return;
            }

            if (itemCount != null)
            {
                if (itemCount.Contains(oldItemCount))
                {
                    itemCount.Remove(oldItemCount);
                }
            }
        }

        /// <summary>
        /// Remove all instances of ItemCount from the collection
        /// </summary>
        /// <pdGenerated>Default removeAll</pdGenerated>
        public void RemoveAllItemCount()
        {
            if (itemCount != null)
            {
                itemCount.Clear();
            }
        }

        public uint GetId()
        {
            return id;
        }

        public void SetId(uint id)
        {
            this.id = id;
        }
    }
}