using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8
{
    interface ICepikData
    {
        int carYear { get; set; }
        string carColor { get; set; }
    }
    interface IStatData
    {
        string carType { get; set; }
        string carMark { get; set; }
        int carVelocity { get; set; }
        int carNumberOfSeats { get; set; }
        string carVIN { get; set; }
    }
    interface IPoliceData
    {
        string ownerName { get; set; }
        string ownerSurname { get; set; }
        string ownerAddress { get; set; }
        long ownerPESEL { get; set; }
        long ownerDrivingLicenceNumber { get; set; }
        DateTime ownerDrivingLicenceDate { get; set; }
        DateTime ownerBuyDate { get; set; }
        int ownerPointsNumber { get; set; }
        long carNumber { get; set; }
        long carPoliceNumber { get; set; }
    }
    class Auto : ICepikData, IStatData, IPoliceData
    {
        // ICepikData
        public int carYear { get; set; }
        public string carColor { get; set; }

        // IStatData
        public string carType { get; set; }
        public string carMark { get; set; }
        public int carVelocity { get; set; }
        public int carNumberOfSeats { get; set; }
        public string carVIN { get; set; }

        // IPoliceData
        public string ownerName { get; set; }
        public string ownerSurname { get; set; }
        public string ownerAddress { get; set; }
        public long ownerPESEL { get; set; }
        public long ownerDrivingLicenceNumber { get; set; }
        public DateTime ownerDrivingLicenceDate { get; set; }
        public DateTime ownerBuyDate { get; set; }
        public int ownerPointsNumber { get; set; }
        public long carNumber { get; set; }
        public long carPoliceNumber { get; set; }
    }
}
