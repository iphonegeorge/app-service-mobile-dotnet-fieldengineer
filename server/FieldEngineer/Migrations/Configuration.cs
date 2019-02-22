namespace FieldEngineer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using FieldEngineerLiteService.DataObjects;

    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<FieldEngineerLiteService.Models.JobDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(FieldEngineerLiteService.Models.JobDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            List<Job> jobs = new List<Job>
            {
                new Job {Title = "Install Deluxe DVR box",Date = "26/2/2019", StartTime = "10:30am", CustomerName = "Chris Anderson", CustomerAddress = "123 Fake St", CustomerPhoneNumber = "3079876543"},
                new Job {Title = "Cable box outside is missing",Date = "25/2/2019", StartTime = "10:30am", CustomerName = "Kirill Gavrylyuk", CustomerAddress = "987 Real St", CustomerPhoneNumber = "4251234567"},
                new Job {Title = "Add Cable to new room",Date = "24/2/2019", StartTime = "10:30am", CustomerName = "Donna Malayeri", CustomerAddress = "456 3rd Dimension", CustomerPhoneNumber = "7860987432"},
                new Job {Title = "Approve free Cable for my employees",Date = "23/2/2019", StartTime = "10:30am", CustomerName = "Bill Staples", CustomerAddress = "777 Best Boss Dr.", CustomerPhoneNumber = "4259829322"}
            };

            foreach (Job job in jobs)
            {
                context.Set<Job>().Add(job);
            }

            base.Seed(context);
        }
    }
}
