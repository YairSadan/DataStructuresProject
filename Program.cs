// See https://aka.ms/new-console-template for more information
Quadtree<Box> tree = new Quadtree<Box>()
{
    Value = new Box() { Width = 2, Height = 2 },
};
tree.Add(new Box() { Width = 1, Height = 1 });
tree.Add(new Box() { Width = 3, Height = 1 });
tree.Add(new Box() { Width = 1, Height = 3 });
tree.Add(new Box() { Width = 3, Height = 3 });
tree.Add(new Box() { Width = 3, Height = 3 });
tree.Add(new Box() { Width = 3, Height = 3 });
tree.SubtractCount(4, 3);
int i = tree.GetCount();
Box desired = tree.SearchBySize(new Box() { Width = 0.1, Height = 0.1 }, 1000);
tree.Delete(2);
Console.ReadLine();

