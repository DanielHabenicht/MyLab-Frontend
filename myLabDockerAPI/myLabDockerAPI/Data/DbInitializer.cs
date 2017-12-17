using myLabDockerAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myLabDockerAPI.Data
{
    /// <summary>
    /// Class to hold everything related to seeding the Database.
    /// </summary>
    public class DbInitializer
    {
        /// <summary>
        /// Initializes the Database.
        /// </summary>
        /// <param name="ctx"></param>
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


            //Look for any Items
            if (!ctx.Items.Any())
            {
                var category = ctx.Categories.FirstOrDefault(c => c.Id == 1);
                var category2 = ctx.Categories.FirstOrDefault(c => c.Id == 2);
                var state1 = ctx.States.FirstOrDefault(s => s.Id == 1);
                var state2 = ctx.States.FirstOrDefault(s => s.Id == 2);
                var state3 = ctx.States.FirstOrDefault(s => s.Id == 3);


                var Items = new Item[]
                {
                new Item{Title="Antenne",Barcode="00234521", Location="Raum 1", Comment="wichtige Information", State=state1, Category=category, ItemAttributes= new List<ItemAttribute>{new RangeAttribute{Title="Test"} } },
                new Item{Title="WLAN Antenne",Barcode="00232231", Location="Raum 1", Comment="wichtige Information", State=state2, Category=category, ItemAttributes= new List<ItemAttribute>{new TextAttribute{Title="Test2"} }},
                new Item{Title="Transformator",Barcode="00546831", Location="Raum 1", Comment="wichtige Information", State=state1, Category=category, ItemAttributes= new List<ItemAttribute>{new TextAttribute{Title="Test3"} }},
                new Item{Title="Adapter",Barcode="00243861", Location="Raum 1", Comment="wichtige Information", State=state3, Category=category2, ItemAttributes= new List<ItemAttribute>{new NumberAttribute{Title="Test4"} }},
                new Item{Title="Kabel",Barcode="00267781", Location="Raum 1", Comment="wichtige Information", State=state1, Category=category2, ItemAttributes= new List<ItemAttribute>{new NumberAttribute{Title="Test5"} }},
                new Item{Title="gedämpftes Kabel",Barcode="00278981", Location="Raum 1", Comment="wichtige Information", State=state2, Category=category2, ItemAttributes= new List<ItemAttribute>{new NumberAttribute{Title="Test6"} }}
                };

                foreach (Item d in Items)
                {
                    ctx.Items.Add(d);
                }
                ctx.SaveChanges();
            }

        }
    }
}
