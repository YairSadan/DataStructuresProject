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

    public T Search(T valueToSearch, int maxDiffernce)
    {
        var (found, desiredValue) = privateSearch(valueToSearch, maxDiffernce);
        if (found) return desiredValue;
        else return null;
    }
    private (bool, T) privateSearch(T valueToSearch, int maxDiffernce)
    {
        // Case it meets the criteria
        if (IsInTheCriteria(Value, valueToSearch, maxDiffernce))
        {
            return (true, Value);
        }

        // Case Smaller height and smaller width
        else if (valueToSearch.Height <= Value.Height && valueToSearch.Width <= Value.Width)
        {
            // Checks whether we have a smaller unit on height and with
            if (Shsw != null)
            {
                var (found, result) = Shsw.privateSearch(valueToSearch, maxDiffernce);
                if (found)
                    return (true, result);
            }

            // Checks whether we have a smaller unit on height but with a greater width
            if (Shgw != null)
            {
                var (found, result) = Shgw.privateSearch(valueToSearch, maxDiffernce);
                if (found)
                {
                    return (true, result);
                }
            }
            return (false, default(T));
        }
        // Case Smaller height and greater width
        else if (valueToSearch.Height <= Value.Height && valueToSearch.Width > Value.Width)
        {
            if (Ghsw != null)
            {
                var (found, result) = Ghsw.privateSearch(valueToSearch, maxDiffernce);
                if (found)
                    return (true, result);
            }

            if (Ghgw != null)
            {
                var (found, result) = Ghgw.privateSearch(valueToSearch, maxDiffernce);
                if (found)
                    return (true, result);
            }
            return (false, default(T));
        }
        // Case Greater height and smaller width
        else if (valueToSearch.Height > Value.Height && valueToSearch.Width <= Value.Width)
        {
            if (Shgw != null)
            {
                var (found, result) = Shgw.privateSearch(valueToSearch, maxDiffernce);
                if (found)
                    return (true, result);
            }
            if (Ghgw != null)
            {
                var (found, result) = Ghgw.privateSearch(valueToSearch, maxDiffernce);
                if (found)
                    return (true, result);
            }
            return (false, default(T));
        }

        // Case Greater height and greater width
        else if (valueToSearch.Height > Value.Height && valueToSearch.Width > Value.Width)
        {
            if (Shsw != null)
            {
                var (found, result) = Shsw.privateSearch(valueToSearch, maxDiffernce);
                if (found)
                    return (true, result);

            }
            if (Shgw != null)
            {
                var (found, result) = Shgw.privateSearch(valueToSearch, maxDiffernce);
                if (found)
                    return (true, result);
            }
            if (Ghsw != null)
            {

                var (found, result) = Ghsw.privateSearch(valueToSearch, maxDiffernce);
                if (found)
                    return (true, result);
            }
            return (false, default(T));

        }
        else return (false, default(T));
    }

    public bool Delete(int id)
    {
        if (Value.Id == id)
        {
            Value.IsDeleted = true;
            return true;
        }
        else if (Shsw != null && Shsw.Delete(id))
            return true;
        else if (Ghsw != null && Ghsw.Delete(id))
            return true;
        else if (Shgw != null && Shgw.Delete(id))
            return true;
        else if (Ghgw != null && Ghgw.Delete(id))
            return true;
        else return false;
    }

    // Check whether the value meets the user differece criteria e.g. if the user criteria is 25% and the size he want is 5cm on 5cm 
    // the given box can be minmum of 5cm on 5cm and maximum of 6.25cm on 6.25cm (5 * 125%)
    private bool IsInTheCriteria(T Value, T ValueToCheck, int maxDiffernce)
    {
        // checks whether it's larger
        if (Value.Height >= ValueToCheck.Height && Value.Width >= ValueToCheck.Width)
        {
            // checks whether it's int the criteria
            if (ValueToCheck.Height * (1 + maxDiffernce / 100) >= Value.Height && ValueToCheck.Width * (1 + maxDiffernce / 100) >= Value.Width)
                return true;
        }
        return false;
    }
}
