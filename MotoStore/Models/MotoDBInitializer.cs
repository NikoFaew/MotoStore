using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace MotoStore.Models
{
    public class MotoDBInitializer : DropCreateDatabaseAlways<MotoContext>
    {
        protected override void Seed(MotoContext db)
        {
            db.Motobikes.Add(new Motobike { Name = "BMW F 750 GS", Company = "BMW", Price = 770880, Color = "Белый", Class = "Эндуро", Power = 48, Existence = "В наличии", YearManufacture = 2020 });
            db.Motobikes.Add(new Motobike { Name = "Wels Impulse ", Company = "Wels", Price = 144880, Color = "Бело с красным", Class = "Спортбайк", Power = 58, Existence = "В наличии", YearManufacture = 2020 });
            db.Motobikes.Add(new Motobike { Name = "KAYO K1 250 ", Company = "KAYO", Price = 100880, Color = "Бело - оранжевый", Class = "Кроссовый", Power = 35, Existence = "В наличии", YearManufacture = 2018 });
            db.Motobikes.Add(new Motobike { Name = "BSE J1-250", Company = "BSE", Price = 90500, Color = "Бело - синий", Class = "Кроссовый", Power = 25, Existence = "В наличии", YearManufacture = 2019 });
            db.Motobikes.Add(new Motobike { Name = "Apollo RXF", Company = "Appolo", Price = 60000, Color = "Бело - красный", Class = "Кроссовый", Power = 23, Existence = "В наличии", YearManufacture = 2020 });
            db.Motobikes.Add(new Motobike { Name = "Aprilia Dorsa", Company = "Aprilia", Price = 800980, Color = "Черный", Class = "Мотард", Power = 58, Existence = "В наличии", YearManufacture = 2020 });
            db.Motobikes.Add(new Motobike { Name = "BMW G 310 GS", Company = "BMW", Price = 799880, Color = "Бело - красный", Class = "Эндуро", Power = 34, Existence = "В наличии", YearManufacture = 2021 });
            db.Motobikes.Add(new Motobike { Name = "Wels Striker", Company = "Wels", Price = 144880, Color = "Бело - синий", Class = "Спортбайк", Power = 58, Existence = "В наличии", YearManufacture = 2020 });
            db.Motobikes.Add(new Motobike { Name = "Yamaha YZF-R3", Company = "Yamaha", Price = 483900, Color = "Cиний", Class = "Спортбайк", Power = 42, Existence = "В наличии", YearManufacture = 2020 });
            db.Motobikes.Add(new Motobike { Name = "KTM Duke 250", Company = "KTM", Price = 120000, Color = "Бело - оранжевый", Class = "Спортбайк", Power = 31, Existence = "В наличии", YearManufacture = 2021 });
            db.Motobikes.Add(new Motobike { Name = "Kawasaki Ninja", Company = "Kawasaki", Price = 400000, Color = "Cеребристый", Class = "Спортбайк", Power = 310, Existence = "В наличии", YearManufacture = 2020 });
            db.Motobikes.Add(new Motobike { Name = "Suzuki GSX", Company = "Suzuki", Price = 200880, Color = "Бело - синий", Class = "Спортбайк", Power = 202, Existence = "В наличии", YearManufacture = 2020 });
            db.Motobikes.Add(new Motobike { Name = "Kawasaki KLX250 ", Company = "Kawasaki", Price = 100000, Color = "Зеленый", Class = "Эндуро", Power = 22, Existence = "В наличии", YearManufacture = 2020 });
            db.Motobikes.Add(new Motobike { Name = "Yamaha WR250F ", Company = "Yamaha", Price = 150000, Color = "Синий", Class = "Эндуро", Power = 22, Existence = "В наличии", YearManufacture = 2020 });

            base.Seed(db);
        } 
        
    }
}