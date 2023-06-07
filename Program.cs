// See https://aka.ms/new-console-template for more information
Quadtree<Box> tree = new Quadtree<Box>();
tree.Value = new Box() { Width = 2, Height = 2 };
tree.Add(new Box() { Id = 1, Width = 1, Height = 1 });
tree.Add(new Box() { Id = 2, Width = 3, Height = 1 });
tree.Add(new Box() { Id = 3, Width = 1, Height = 3 });
tree.Add(new Box() { Id = 4, Width = 3, Height = 3 });

Box desired = tree.Search(new Box() { Width = 6, Height = 8 }, 100);
Console.ReadLine();

