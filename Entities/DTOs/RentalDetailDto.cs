﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class RentalDetailDto : IDto
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public int UserId { get; set; }
        public string BrandName { get; set; }
        public string CarName { get; set; }
        public string ColorName { get; set; }
        public string UserName { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; }
        public decimal DailyPrice { get; set; }
        public int TotalRentDay { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
