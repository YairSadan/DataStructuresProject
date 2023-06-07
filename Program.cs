// See https://aka.ms/new-console-template for more information
Quadtree<Box> tree = new Quadtree<Box>();
tree.Value = new Box() { Width = 2, Height = 2 };
tree.Add(new Box() { Id = 1, Width = 1, Height = 1, IsDeleted = false });
tree.Add(new Box() { Id = 2, Width = 3, Height = 1, IsDeleted = false });
tree.Add(new Box() { Id = 3, Width = 1, Height = 3, IsDeleted = false });
tree.Add(new Box() { Id = 4, Width = 3, Height = 3, IsDeleted = false });

Box desired = tree.Search(new Box() { Width = 0.1, Height = 0.1 }, 1000);
tree.Delete(9);
Console.ReadLine();

