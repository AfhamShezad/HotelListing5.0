﻿using HotelListing5._0.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing5._0.Configurations.Entities
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Sandals Resort And Spa",
                    Address = "Negril",
                    CountryId = 1,
                    Rating = 4.5
                },
                 new Hotel
                 {
                     Id = 2,
                     Name = "Comfort Suites",
                     Address = "George Town",
                     CountryId = 3,
                     Rating = 4.3
                 },
                  new Hotel
                  {
                      Id = 3,
                      Name = "Grand Palldium",
                      Address = "Nassua",
                      CountryId = 2,
                      Rating = 4
                  }

            );
        }
    }
}
