using Learning.Classes;



Woman figure1 = new Woman();
figure1.Name = "Catwoman";
figure1.Height = 150;
figure1.Material = "Resin";
figure1.BeautyRating = 10;
Console.WriteLine(figure1.Name);
Console.WriteLine(figure1.Height);
Console.WriteLine(figure1.Material);
Console.WriteLine(figure1.BeautyRating);

Mens figure2 = new Mens();
figure2.Name = "Rainer";
figure2.Height = 70;
figure2.Material = "Resin";
figure2.Muscles = "Heavy with armor";
Console.WriteLine(figure2.Name);
Console.WriteLine(figure2.Height);
Console.WriteLine(figure2.Material);
Console.WriteLine(figure2.Muscles);

Other figure3 = new Other();
figure3.Name = "Lazure dragon";
figure3.Height = 100;
figure3.Material = "Resin";
figure3.Painted = true;
Console.WriteLine(figure3.Name);
Console.WriteLine(figure3.Height);
Console.WriteLine(figure3.Material);
Console.WriteLine(figure3.Painted);


