public class Quadtree<T> where T : Box
{
    public T Value { get; set; }
    public Quadtree<T> Shsw { get; set; } // Smaller height and smaller width
    public Quadtree<T> Shgw { get; set; } // Smaller height and greater width
    public Quadtree<T> Ghgw { get; set; } // Greater height and greater width
    public Quadtree<T> Ghsw { get; set; } // greater height and smaller width

    public bool Add(T valueToAdd)
    {
        // Case Smaller height and smaller width
        if (valueToAdd.Height <= Value.Height && valueToAdd.Width <= Value.Width)
        {
            if (Shsw == null)
            {
                Shsw = new Quadtree<T>();
                Shsw.Value = valueToAdd;
                return true;
            }
            else return Shsw.Add(valueToAdd);
        }

        // Case Smaller height and greater width
        else if (valueToAdd.Height <= Value.Height && valueToAdd.Width > Value.Width)
        {
            if (Shgw == null)
            {
                Shgw = new Quadtree<T>();
                Shgw.Value = valueToAdd;
                return true;
            }
            else return Shgw.Add(valueToAdd);
        }

        // Case Greater height and greater width
        else if (valueToAdd.Height > Value.Height && valueToAdd.Width > Value.Width)
        {
            if (Ghgw == null)
            {
                Ghgw = new Quadtree<T>();
                Ghgw.Value = valueToAdd;
                return true;
            }
            else return Ghgw.Add(valueToAdd);
        }

        // Case Greater height and smaller width
        else if (valueToAdd.Height > Value.Height && valueToAdd.Width <= Value.Width)
        {
            if (Ghsw == null)
            {
                Ghsw = new Quadtree<T>();
                Ghsw.Value = valueToAdd;
                return true;
            }
            else return Ghsw.Add(valueToAdd);
        }
        else return false;
    }
    private int _foundValueId;
    public T Search(T valueToSearch)
    {
        // Case equal to value
        if (valueToSearch == Value) return Value;

        // Case Smaller height and smaller width
        else if (valueToSearch.Height <= Value.Height && valueToSearch.Width <= Value.Width)
        {
            if (Shsw == null)
                return this.Value;
            else
                return Shsw.Search(valueToSearch);
        }

        // Case Smaller height and greater width
        else if (valueToSearch.Height <= Value.Height && valueToSearch.Width > Value.Width)
        {
            if (Shgw == null)
                return this.Value;
            else
                return Shgw.Search(valueToSearch);
        }

        // Case Greater height and smaller width
        else if (valueToSearch.Height > Value.Height && valueToSearch.Width <= Value.Width)
        {
            if (Ghsw == null)
                return this.Value;
            else
                return Ghsw.Search(valueToSearch);
        }
        // Case Greater height and greater width
        else if (Value.Height <= valueToSearch.Height && valueToSearch.Width <= valueToSearch.Width)
        {
            if (Ghgw == null)
                return this.Value;
            else
                return Ghgw.Search(valueToSearch);
        }
        else return null;
    }
}
