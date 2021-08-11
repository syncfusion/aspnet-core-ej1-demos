#region Copyright Syncfusion Inc. 2001-2021.
// Copyright Syncfusion Inc. 2001-2021. All rights reserved.
// Use of this code is subject to the terms of our license.
// A copy of the current license can be obtained at any time by e-mailing
// licensing@syncfusion.com. Any infringement will be prosecuted under
// applicable laws. 
#endregion
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace samplebrowser.Models
{
    public class ScheduleData
    {
        public List<AppointmentData> GetAppData()
        {
            List<AppointmentData> appData = new List<AppointmentData>();
            appData.Add(new AppointmentData { Id = 1, Subject = "Bering Sea Gold", Description = "", StartTime = new DateTime(2017, 6, 5, 10, 0, 0), EndTime = new DateTime(2017, 6, 5, 11, 0, 0), AllDay = false, Recurrence = false, RecurrenceRule = "", Categorize = "1,3", Priority = "medium", RoomId = "1", OwnerId = "1" });
            appData.Add(new AppointmentData { Id = 2, Subject = "Hello Sea Gold", Description = "", StartTime = new DateTime(2017, 6, 2, 16, 0, 0), EndTime = new DateTime(2017, 6, 2, 17, 30, 0), AllDay = false, Recurrence = false, RecurrenceRule = "", Categorize = "2,5", Priority = "high", RoomId = "1", OwnerId = "5" });
            appData.Add(new AppointmentData { Id = 3, Subject = "What Happened Next?", Description = "", StartTime = new DateTime(2017, 6, 4, 1, 0, 0), EndTime = new DateTime(2017, 6, 4, 1, 30, 0), AllDay = false, Recurrence = false, RecurrenceRule = "", Categorize = "3,6", Priority = "low", RoomId = "2", OwnerId = "3" });
            appData.Add(new AppointmentData { Id = 4, Subject = "Meeting", Description = "", StartTime = new DateTime(2017, 6, 5, 12, 30, 0), EndTime = new DateTime(2017, 6, 5, 15, 0, 0), AllDay = false, Recurrence = false, RecurrenceRule = "", Categorize = "4,1", Priority = "medium", RoomId = "1", OwnerId = "1" });
            appData.Add(new AppointmentData { Id = 5, Subject = "Daily Planet", Description = "", StartTime = new DateTime(2017, 6, 3, 1, 0, 0), EndTime = new DateTime(2017, 6, 3, 2, 0, 0), AllDay = false, Recurrence = false, RecurrenceRule = "", Categorize = "1,3,6", Priority = "hign", RoomId = "1", OwnerId = "5" });
            appData.Add(new AppointmentData { Id = 6, Subject = "Alaska: The Last Frontier", Description = "", StartTime = new DateTime(2017, 6, 3, 4, 0, 0), EndTime = new DateTime(2017, 6, 3, 5, 0, 0), AllDay = false, Recurrence = false, RecurrenceRule = "", Categorize = "2,3,4,5", Priority = "low", RoomId = "2", OwnerId = "3" });
            appData.Add(new AppointmentData { Id = 7, Subject = "Deadest Catch", Description = "", StartTime = new DateTime(2017, 6, 3, 16, 0, 0), EndTime = new DateTime(2017, 6, 3, 17, 0, 0), AllDay = false, Recurrence = false, RecurrenceRule = "", Categorize = "2,4,6,1", Priority = "medium", RoomId = "1", OwnerId = "1" });
            appData.Add(new AppointmentData { Id = 8, Subject = "Sports Day", Description = "", StartTime = new DateTime(2017, 5, 30, 6, 30, 0), EndTime = new DateTime(2017, 5, 30, 7, 30, 0), AllDay = false, Recurrence = false, RecurrenceRule = "", Categorize = "5,3", Priority = "high", RoomId = "1", OwnerId = "5" });
            appData.Add(new AppointmentData { Id = 9, Subject = "How It's Made", Description = "", StartTime = new DateTime(2017, 6, 1, 6, 0, 0), EndTime = new DateTime(2017, 6, 1, 7, 30, 0), AllDay = false, Recurrence = true, RecurrenceRule = "FREQ=WEEKLY;BYDAY=MO,TU;INTERVAL=1;COUNT=15", Categorize = "2,3,6", Priority = "low", RoomId = "2", OwnerId = "3" });
            appData.Add(new AppointmentData { Id = 10, Subject = "Bering Sea Gold", Description = "", StartTime = new DateTime(2017, 6, 2, 6, 0, 0), EndTime = new DateTime(2017, 6, 2, 8, 0, 0), AllDay = false, Recurrence = true, RecurrenceRule = "FREQ=DAILY;INTERVAL=2;COUNT=10", Categorize = "3", Priority = "medium", RoomId = "1", OwnerId = "1" });
            appData.Add(new AppointmentData { Id = 11, Subject = "MoonShiners", Description = "", StartTime = new DateTime(2017, 6, 2, 2, 0, 0), EndTime = new DateTime(2017, 6, 2, 2, 30, 0), AllDay = false, Recurrence = true, RecurrenceRule = "FREQ=DAILY;INTERVAL=1;COUNT=5", Categorize = "6,2,5", Priority = "high", RoomId = "1", OwnerId = "5" });
            appData.Add(new AppointmentData { Id = 12, Subject = "Close Encounters", Description = "", StartTime = new DateTime(2017, 5, 30, 14, 0, 0), EndTime = new DateTime(2017, 5, 30, 15, 0, 0), AllDay = false, Recurrence = true, RecurrenceRule = "FREQ=WEEKLY;BYDAY=MO,TH;INTERVAL=1;COUNT=5", Categorize = "3,4,5", Priority = "low", RoomId = "2", OwnerId = "3" });
            appData.Add(new AppointmentData { Id = 13, Subject = "The Last Frontier", Description = "", StartTime = new DateTime(2017, 5, 30, 3, 0, 0), EndTime = new DateTime(2017, 5, 30, 3, 30, 0), AllDay = false, Recurrence = true, RecurrenceRule = "FREQ=WEEKLY;BYDAY=WE;INTERVAL=1;COUNT=3", Categorize = "5,2,1", Priority = "medium", RoomId = "1", OwnerId = "1" });
            appData.Add(new AppointmentData { Id = 14, Subject = "HighWay Thru Hell", Description = "", StartTime = new DateTime(2017, 6, 1, 3, 0, 0), EndTime = new DateTime(2017, 6, 1, 7, 0, 0), AllDay = false, Recurrence = false, RecurrenceRule = "", Categorize = "5,6,3", Priority = "high", RoomId = "1", OwnerId = "5" });
            appData.Add(new AppointmentData { Id = 15, Subject = "Moon Shiners", Description = "", StartTime = new DateTime(2017, 6, 2, 4, 20, 0), EndTime = new DateTime(2017, 6, 2, 5, 50, 0), AllDay = false, Recurrence = false, RecurrenceRule = "", Categorize = "1,2,3,4,5,6", Priority = "low", RoomId = "2", OwnerId = "3" });
            appData.Add(new AppointmentData { Id = 16, Subject = "Cash Cab", Description = "", StartTime = new DateTime(2017, 5, 30, 15, 0, 0), EndTime = new DateTime(2017, 5, 30, 16, 30, 0), AllDay = false, Recurrence = true, RecurrenceRule = "FREQ=DAILY;INTERVAL=1;COUNT=5", Categorize = "1,3", Priority = "medium", RoomId = "1", OwnerId = "1" });
            appData.Add(new AppointmentData { Id = 17, Subject = "Opening ceremony", Description = "", StartTime = new DateTime(2017, 6, 1, 9, 0, 0), EndTime = new DateTime(2017, 6, 1, 12, 0, 0), AllDay = false, Recurrence = false, RecurrenceRule = "", Categorize = "1,4,3", Priority = "high", RoomId = "1", OwnerId = "5" });
            appData.Add(new AppointmentData { Id = 18, Subject = "Spring Break", Description = "", StartTime = new DateTime(2017, 6, 4, 6, 0, 0), EndTime = new DateTime(2017, 6, 4, 7, 30, 0), AllDay = false, Recurrence = false, RecurrenceRule = "", Categorize = "1", Priority = "low", RoomId = "2", OwnerId = "3" });
            appData.Add(new AppointmentData { Id = 19, Subject = "Yoga", Description = "", StartTime = new DateTime(2017, 6, 2, 12, 20, 0), EndTime = new DateTime(2017, 6, 2, 14, 15, 0), AllDay = false, Recurrence = true, RecurrenceRule = "FREQ=WEEKLY;BYDAY=FR;INTERVAL=1;COUNT=3", Categorize = "1", Priority = "medium", RoomId = "1", OwnerId = "1" });
            appData.Add(new AppointmentData { Id = 20, Subject = "Finals SUI - SWE", Description = "", StartTime = new DateTime(2017, 6, 5, 16, 0, 0), EndTime = new DateTime(2017, 6, 5, 18, 0, 0), AllDay = false, Recurrence = false, RecurrenceRule = "", Categorize = "1", Priority = "medium", RoomId = "1", OwnerId = "5" });
            return appData;
        }

        public List<BlockoutData> GetBlockData()
        {
            List<BlockoutData> blockData = new List<BlockoutData>();
            blockData.Add(new BlockoutData { Id = 1, Subject = "MAINTENANCE", StartTime = new DateTime(2017, 6, 5, 8, 0, 0), EndTime = new DateTime(2017, 6, 5, 10, 0, 0), GroupId = "2", OwnerId = "3", BlockAppointment = true, AllDay = false });
            blockData.Add(new BlockoutData { Id = 2, Subject = "SERVICE", StartTime = new DateTime(2017, 6, 5, 9, 0, 0), EndTime = new DateTime(2017, 6, 5, 11, 0, 0), GroupId = "1", OwnerId = "1", BlockAppointment = true, AllDay = false });
            blockData.Add(new BlockoutData { Id = 3, Subject = "SERVICE", StartTime = new DateTime(2017, 6, 6), EndTime = new DateTime(2017, 6, 6), GroupId = "1", OwnerId = "1", BlockAppointment = true, AllDay = true });
            blockData.Add(new BlockoutData { Id = 4, Subject = "BAD MONSOON", StartTime = new DateTime(2017, 6, 5, 15, 30, 0), EndTime = new DateTime(2017, 6, 5, 17, 0, 0), GroupId = "1", OwnerId = "1", BlockAppointment = true, AllDay = false });
            blockData.Add(new BlockoutData { Id = 5, Subject = "BAD MONSOON", StartTime = new DateTime(2017, 6, 5, 15, 30, 0), EndTime = new DateTime(2017, 6, 5, 17, 0, 0), GroupId = "2", OwnerId = "3", BlockAppointment = true, AllDay = false });
            blockData.Add(new BlockoutData { Id = 6, Subject = "BAD MONSOON", StartTime = new DateTime(2017, 6, 5, 15, 30, 0), EndTime = new DateTime(2017, 6, 5, 17, 0, 0), GroupId = "1", OwnerId = "5", BlockAppointment = true, AllDay = false });
            return blockData;
        }
    }

    public class AppointmentData
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public string RoomId { get; set; }
        public string OwnerId { get; set; }
        public bool? AllDay { get; set; }
        public bool? Recurrence { get; set; }
        public string Priority { get; set; }
        public string Categorize { get; set; }
        public string RecurrenceRule { get; set; }
        public string StartTimeZone { get; set; }
        public string EndTimeZone { get; set; }
    }

    public class BlockoutData
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string OwnerId { get; set; }
        public string GroupId { get; set; }
        public bool AllDay { get; set; }
        public bool BlockAppointment { get; set; }
    }
}
