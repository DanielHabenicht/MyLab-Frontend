using myLabDockerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabDockerAPI.Data
{
    public class DbInitializer
    {
        public static void Initialize(MyLabContext context)
        {
            context.Database.EnsureCreated();

            //Look for any Devices
            if (!context.Devices.Any())
            {
                var devices = new Device[]
                {
                new Device{Title="Antenne",InventoryNumber="00234521", Type="Typ", Location="Raum 1", Comment="wichtige Information", State="verfügbar"},
                new Device{Title="WLAN Antenne",InventoryNumber="00232231", Type="Typ", Location="Raum 1", Comment="wichtige Information", State="verfügbar"},
                new Device{Title="Transformator",InventoryNumber="00546831", Type="Typ", Location="Raum 1", Comment="wichtige Information", State="verfügbar"},
                new Device{Title="Adapter",InventoryNumber="00243861", Type="Typ", Location="Raum 1", Comment="wichtige Information", State="verfügbar"},
                new Device{Title="Kabel",InventoryNumber="00267781", Type="Typ", Location="Raum 1", Comment="wichtige Information", State="verfügbar"},
                new Device{Title="gedämpftes Kabel",InventoryNumber="00278981", Type="Typ", Location="Raum 1", Comment="wichtige Information", State="verfügbar"}
                };

                foreach (Device d in devices)
                {
                    context.Devices.Add(d);
                }
                context.SaveChanges();
            }

            if (!context.Laboratories.Any())
            {
                var laboratories = new Laboratory[]
                {
                    new Laboratory{Title="Labor 1"}
                };

                foreach(Laboratory l in laboratories)
                {
                    context.Laboratories.Add(l);
                }
                context.SaveChanges();
            }

            if (!context.Categories.Any())
            {
                var lab = context.Laboratories.FirstOrDefault(d => d.Id == 1);
                var categories = new Category[]
                {
                    
                    new Category{Title="1.Kategorie", Comment="Kommentar", IsTemplate=false, Laboratory=lab },
                    new Category{Title="2.Kategorie", Comment="Kommentar", IsTemplate=false, Laboratory=lab }

                };

                foreach (Category d in categories)
                {
                    context.Categories.Add(d);
                }
                context.SaveChanges();
            }
        }
    }
}
