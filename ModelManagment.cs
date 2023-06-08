namespace DataStructuresProject;
public class ModelManagment
{
    Quadtree<Box> tree = new Quadtree<Box>()
    {
        Value = new Box() { Width = 2, Height = 2 },
    };
    public void MakePruchase(string width, string height, string maxDiffernce)
    {
        int maxDiffernce1 = int.Parse(maxDiffernce);
        Box box = new Box()
        {
            Height = double.Parse(height),
            Width = double.Parse(width),
        };
        var (found, result) = tree.privateSearch(box, maxDiffernce1);
        if (found)
        {
            AskTheUserTheAmount(result.Count, result);
        }
    }

    private void AskTheUserTheAmount(int count, Box result)
    {
        int desiredAmount = 0; // user input;
        if (desiredAmount < count)
        {
            result.Count -= desiredAmount;
        }

    }
}