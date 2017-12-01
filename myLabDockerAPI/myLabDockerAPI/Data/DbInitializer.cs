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
            if (context.Devices.Any())
            {
                return; //DB has already been seeded
            }

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
    }
}
