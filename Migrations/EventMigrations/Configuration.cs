namespace ZenithWebSite.Migrations.EventMigrations
{
    using Models.Entity;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ZenithWebSite.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\EventMigrations";
        }

        protected override void Seed(ZenithWebSite.Models.ApplicationDbContext context)
        {
            context.Activity.AddOrUpdate(a => a.activityId, getActivities());
            context.SaveChanges();

            context.Event.AddOrUpdate(e => e.eventId, getEvents());
            context.SaveChanges();
        }

        private Event[] getEvents()
        {
            var events = new List<Event>
            {
               new Event() { eventId=1, eventFrom=new DateTime(2017,2,1,15,30,00), eventTo=new DateTime(2017,2,1,16,30,00), username="userBanana", createEvent=new DateTime(2017,1,18), isActive=true, activityId=101  },
               new Event() { eventId=2, eventFrom=new DateTime(2017,2,4,12,30,00), eventTo=new DateTime(2017,2,4,13,30,00), username="userBanana", createEvent=new DateTime(2017,1,12), isActive=true, activityId=102 },
               new Event() { eventId=3, eventFrom=new DateTime(2017,2,5,11,30,00), eventTo=new DateTime(2017,2,5,14,30,00), username="userOrange", createEvent=new DateTime(2017,1,30), isActive=false, activityId=104  },
               new Event() { eventId=4, eventFrom=new DateTime(2017,2,5,18,30,00), eventTo=new DateTime(2017,2,5,20,30,00), username="userApple", createEvent=new DateTime(2017,1,14), isActive=false, activityId=103  },
               new Event() { eventId=5, eventFrom=new DateTime(2017,2,6,15,30,00), eventTo=new DateTime(2017,2,6,16,30,00), username="userLemon", createEvent=new DateTime(2017,1,18), isActive=true, activityId=105  },
               new Event() { eventId=6, eventFrom=new DateTime(2017,2,7,15,30,00), eventTo=new DateTime(2017,2,7,16,30,00), username="userLemon", createEvent=new DateTime(2016,12,17), isActive=false, activityId=106  },
               new Event() { eventId=7, eventFrom=new DateTime(2017,2,8,15,30,00), eventTo=new DateTime(2017,2,8,16,30,00), username="userSweet", createEvent=new DateTime(2017,1,10), isActive=true, activityId=104  },
               new Event() { eventId=8, eventFrom=new DateTime(2017,2,10,10,30,00), eventTo=new DateTime(2017,2,10,14,30,00), username="userMushroom", createEvent=new DateTime(2017,1,6), isActive=false, activityId=101  },


            };
            return events.ToArray();
        }

        private Activity[] getActivities()
        {
            var activities = new List<Activity>
            {
               new Activity() { activityId=101, description="Senior¡¯s Golf Tournament", createActivity=new DateTime(2016,12,6) },
               new Activity() { activityId=102, description="Leadership General Assembly Meeting", createActivity=new DateTime(2016,12,3) },
               new Activity() { activityId=103, description="Youth Bowling Tournament", createActivity=new DateTime(2016,11,20) },
               new Activity() { activityId=104, description="Young ladies cooking lessons", createActivity=new DateTime(2016,10,4) },
               new Activity() { activityId=105, description="Pancake Breakfast", createActivity=new DateTime(2016,10,17) },
               new Activity() { activityId=106, description="Swimming Exercise for parents", createActivity=new DateTime(2016,11,25) },
            };
            return activities.ToArray();
        }



    }
}
