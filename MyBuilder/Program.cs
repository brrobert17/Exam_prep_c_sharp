using MyBuilder;

var c1 = new CarBuilder().AddModel("POLO").AddBrand("VW").AddYear(2000).Build();
c1.DisplayInfo();

var c2 = new CarBuilder().AddModel("GOLF").AddYear(2019).Build();
c2.DisplayInfo();

var c3 = new CarBuilder()
    .AddYear(1999)
    .AddBrand("VolksWagen")
    .AddModel("PASSAT")
    .AddOwner("Soheil")
    .AddOwner("Robert")
    .AddOwner("Adam")
    .AddYear(2020).Build();
c3.DisplayInfo();
