using myLabDockerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabDockerAPI.Data
{
    public class DbInitializer
    {
        public static void Initialize(MyLabContext ctx)
        {
            ctx.Database.EnsureCreated();

            //Look for any States
            if (!ctx.States.Any())
            {
                var states = new State[]
                {
                    new State{Title="verfügbar"},
                    new State{Title="entliehen"},
                    new State{Title="kaputt/in Reperatur"}
                };

                foreach (State s in states)
                {
                    ctx.States.Add(s);
                }
                ctx.SaveChanges();
            }

            //Look for any Laboratory
            if (!ctx.Laboratories.Any())
            {
                var laboratories = new Laboratory[]
                {
                    new Laboratory{Title="Labor 1"}
                };

                foreach (Laboratory l in laboratories)
                {
                    ctx.Laboratories.Add(l);
                }
                ctx.SaveChanges();
            }

            //Look for any Category
            if (!ctx.Categories.Any())
            {
                var lab = ctx.Laboratories.FirstOrDefault(d => d.Id == 1);
                var categories = new Category[]
                {

                    new Category{Title="1.Kategorie", Comment="Kommentar", IsTemplate=false, Laboratory=lab },
                    new Category{Title="2.Kategorie", Comment="Kommentar", IsTemplate=false, Laboratory=lab }

                };

                foreach (Category d in categories)
                {
                    ctx.Categories.Add(d);
                }
                ctx.SaveChanges();
            }


            //Look for any Devices
            if (!ctx.Devices.Any())
            {
                var category = ctx.Categories.FirstOrDefault(c => c.Id == 1);
                var category2 = ctx.Categories.FirstOrDefault(c => c.Id == 2);
                var state1 = ctx.States.FirstOrDefault(s => s.Id == 1);
                var state2 = ctx.States.FirstOrDefault(s => s.Id == 2);
                var state3 = ctx.States.FirstOrDefault(s => s.Id == 3);


                var devices = new Device[]
                {
                new Device{Title="Antenne",InventoryNumber="00234521", Location="Raum 1", Comment="wichtige Information", State=state1, Category=category, DeviceAttributes= new List<DeviceAttribute>{new RangeAttribute{Title="Test"} } },
                new Device{Title="WLAN Antenne",InventoryNumber="00232231", Location="Raum 1", Comment="wichtige Information", State=state2, Category=category, DeviceAttributes= new List<DeviceAttribute>{new DeviceAttribute{Title="Test2"} }},
                new Device{Title="Transformator",InventoryNumber="00546831", Location="Raum 1", Comment="wichtige Information", State=state1, Category=category, DeviceAttributes= new List<DeviceAttribute>{new DeviceAttribute{Title="Test3"} }},
                new Device{Title="Adapter",InventoryNumber="00243861", Location="Raum 1", Comment="wichtige Information", State=state3, Category=category2, DeviceAttributes= new List<DeviceAttribute>{new DeviceAttribute{Title="Test4"} }},
                new Device{Title="Kabel",InventoryNumber="00267781", Location="Raum 1", Comment="wichtige Information", State=state1, Category=category2, DeviceAttributes= new List<DeviceAttribute>{new DeviceAttribute{Title="Test5"} }},
                new Device{Title="gedämpftes Kabel",InventoryNumber="00278981", Location="Raum 1", Comment="wichtige Information", State=state2, Category=category2, DeviceAttributes= new List<DeviceAttribute>{new DeviceAttribute{Title="Test6"} }}
                };

                foreach (Device d in devices)
                {
                    ctx.Devices.Add(d);
                }
                ctx.SaveChanges();
            }

        }
    }
}
