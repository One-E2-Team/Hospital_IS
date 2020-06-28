// File:    StationaryRoomPatientsState.cs
// Author:  fmaster
// Created: Thursday, May 21, 2020 10:21:32 PM
// Purpose: Definition of Class StationaryRoomPatientsState

using System;

namespace Model.Rooms
{
    public class StationaryRoomPatientsState : Repository.IIdentifiable<uint>
    {
        private DateTime timestamp;
        private uint patientsNumber;
        private uint roomId;
        private uint id;

        public StationaryRoomPatientsState(DateTime timestamp, uint patientsNumber, uint roomId)
        {
            this.timestamp = timestamp;
            this.patientsNumber = patientsNumber;
            this.roomId = roomId;
            id = 0;
        }

        public StationaryRoomPatientsState(uint id, DateTime timestamp, uint patientsNumber, uint roomId)
        {
            this.timestamp = timestamp;
            this.patientsNumber = patientsNumber;
            this.roomId = roomId;
            this.id = id;
        }

        public DateTime Timestamp
        {
            get => timestamp;
            set => timestamp = value;
        }

        public uint PatientsNumber
        {
            get => patientsNumber;
            set => patientsNumber = value;
        }

        public uint RoomId
        {
            get => roomId;
            set => roomId = value;
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