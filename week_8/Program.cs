// See https://aka.ms/new-console-template for more information

using week_8;

Letter letter1 = new Letter("TT22345", 1);

Letter letter2 = new Letter("TT5678", 0.5);

Parcel parcel1 = new Parcel("TT56789", 23, "30x40x50");

Parcel parcel2 = new Parcel("TT678909876", 12, "45x56x78");

letter1.PrintInfo();
parcel2.PrintInfo();

CargoContainer<DeliveryItem> myCargo = new CargoContainer<DeliveryItem>();

myCargo.AddItem(letter1);
myCargo.AddItem(letter2);
myCargo.AddItem(parcel1);
myCargo.AddItem(parcel2);

Console.WriteLine(myCargo.GetCost());