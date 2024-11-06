
using System;
using System.Collections.Generic;

namespace devexsample1.Models {
    static class SampleData {
        public static List<Users> UsersData = GetSampleData();

        private static List<Users> GetSampleData()
        {
            var users = new List<Users>();

            for (int i = 1; i <= 200; i++)
            {
                users.Add(new Users
                {
                    Id = i,
                    Name = $"User {i}",
                    UserName = $"user{i}",
                    Email = $"user{i}@example.com",
                    Amount = (i * 10) % 1000 + 50.00 // Example amount calculation
                });
            }

            return users;
        }
    }
}
    