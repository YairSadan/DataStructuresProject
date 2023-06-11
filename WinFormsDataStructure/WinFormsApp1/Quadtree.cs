using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace WinFormsApp1 {
    public class Quadtree<T> where T : Box {
        public T Value { get; set; }
        public Quadtree<T>? Shsw { get; set; } // Smaller height and smaller width
        public Quadtree<T>? Shgw { get; set; } // Smaller height and greater width
        public Quadtree<T>? Ghgw { get; set; } // Greater height and greater width
        public Quadtree<T>? Ghsw { get; set; } // greater height and smaller width
        public int Count { get { return GetCount(); } }

        public bool Add(T valueToAdd) {
            if (valueToAdd.Equals(Value)) {
                Value.Count++;
                return true;
            }
            // Case Smaller height and smaller width
            if (valueToAdd.Height <= Value.Height && valueToAdd.Width <= Value.Width) {
                if (Shsw == null) {
                    Shsw = new Quadtree<T>();
                    Shsw.Value = valueToAdd;
                    return true;
                } else return Shsw.Add(valueToAdd);
            }

            // Case Smaller height and greater width
            else if (valueToAdd.Height <= Value.Height && valueToAdd.Width > Value.Width) {
                if (Shgw == null) {
                    Shgw = new Quadtree<T>();
                    Shgw.Value = valueToAdd;
                    return true;
                } else return Shgw.Add(valueToAdd);
            }

            // Case Greater height and greater width
            else if (valueToAdd.Height > Value.Height && valueToAdd.Width > Value.Width) {
                if (Ghgw == null) {
                    Ghgw = new Quadtree<T>();
                    Ghgw.Value = valueToAdd;
                    return true;
                } else return Ghgw.Add(valueToAdd);
            }

            // Case Greater height and smaller width
            else if (valueToAdd.Height > Value.Height && valueToAdd.Width <= Value.Width) {
                if (Ghsw == null) {
                    Ghsw = new Quadtree<T>();
                    Ghsw.Value = valueToAdd;
                    return true;
                } else return Ghsw.Add(valueToAdd);
            } else return false;
        }

        public (bool, T) SearchByClosestSize(T valueToSearch, int maxDifference) {
            // Case it meets the criteria
            if (IsInTheCriteria(Value, valueToSearch, maxDifference)) {
                return (true, Value);
            }

            // Case Smaller height and smaller width
            else if (valueToSearch.Height <= Value.Height && valueToSearch.Width <= Value.Width) {
                // Checks whether we have a smaller unit on height and width
                if (Shsw != null) {
                    var (found, result) = Shsw.SearchByClosestSize(valueToSearch, maxDifference);
                    if (found)
                        return (true, result);
                }

                // Checks whether we have a smaller unit on height but with a greater width
                if (Shgw != null) {
                    var (found, result) = Shgw.SearchByClosestSize(valueToSearch, maxDifference);
                    if (found) {
                        return (true, result);
                    }
                }

                // Checks whether we have a smaller unit on width but with a greater height
                if (Ghsw != null) {
                    var (found, result) = Ghsw.SearchByClosestSize(valueToSearch, maxDifference);
                    if (found) {
                        return (true, result);
                    }
                }

                // Checks whether we have a larger unit on height and width
                if (Ghgw != null) {
                    var (found, result) = Ghgw.SearchByClosestSize(valueToSearch, maxDifference);
                    if (found) {
                        return (true, result);
                    }
                }
                return (false, default(T));
            }


            // Case Smaller height and greater width
            else if (valueToSearch.Height <= Value.Height && valueToSearch.Width > Value.Width) {

                // Checks whether we have a smaller unit on height but with a greater width
                if (Shgw != null) {
                    var (found, result) = Shgw.SearchByClosestSize(valueToSearch, maxDifference);
                    if (found)
                        return (true, result);
                }

                // Checks whether we have a larger unit on height and width
                if (Ghgw != null) {
                    var (found, result) = Ghgw.SearchByClosestSize(valueToSearch, maxDifference);
                    if (found)
                        return (true, result);
                }
                return (false, default(T));
            }


            // Case Greater height and smaller width
            else if (valueToSearch.Height > Value.Height && valueToSearch.Width <= Value.Width) {
                
                // Checks whether we have a greater unit on height but with a smaller width
                if (Ghsw != null) {
                    var (found, result) = Ghsw.SearchByClosestSize(valueToSearch, maxDifference);
                    if (found)
                        return (true, result);
                }

                // Checks whether we have a larger unit on height and width
                if (Ghgw != null) {
                    var (found, result) = Ghgw.SearchByClosestSize(valueToSearch, maxDifference);
                    if (found)
                        return (true, result);
                }
                return (false, default(T));
            }

            // Case Greater height and greater width
            else if (valueToSearch.Height > Value.Height && valueToSearch.Width > Value.Width) {
                if (Ghgw != null) {
                    var (found, result) = Ghgw.SearchByClosestSize(valueToSearch, maxDifference);
                    if (found)
                        return (true, result);

                }
                return (false, default(T));
            }
            else return (false, default(T));
        }
        // Check whether the value meets the user difference criteria e.g. if the user criteria is 25% and the size he want is 5cm on 5cm 
        // the given box can be minimum of 5cm on 5cm and maximum of 6.25cm on 6.25cm (5 * 125%)
        private bool IsInTheCriteria(T Value, T ValueToCheck, int maxDifference) {
            // checks whether it's larger
            if (Value.Height >= ValueToCheck.Height && Value.Width >= ValueToCheck.Width) {
                // checks whether it's int the criteria
                if (ValueToCheck.Height * (1 + maxDifference / 100) >= Value.Height && ValueToCheck.Width * (1 + maxDifference / 100) >= Value.Width)
                    return true;
            }
            return false;
        }

        public (bool, T) SearchById(int id) {
            if (Value.Id == id)
                return (true, Value);
            if (Shsw != null) {
                var (found, result) = Shsw.SearchById(id);
                if (found)
                    return (true, result);
            }
            if (Shgw != null) {
                var (found, result) = Shgw.SearchById(id);
                if (found)
                    return (true, result);
            }
            if (Ghsw != null) {
                var (found, result) = Ghsw.SearchById(id);
                if (found)
                    return (true, result);
            }
            if (Ghgw != null) {
                var (found, result) = Ghgw.SearchById(id);
                if (found)
                    return (true, result);
            }
            return (false, default(T));
        }

        public void Delete(int id) {
            var (found, valueToModify) = SearchById(id);
            if (found)
                valueToModify.Count = 0;
        }

        public void SubtractCount(int id, int amount) {
            var (found, result) = SearchById(id);
            if (found) {
                if (result.Count - amount < 0) {
                    result.Count = 0;
                } else {
                    result.Count -= amount;
                }
            }
        }

        public List<T> GetAll() {
            var result = new List<T>();
            recursiveGetAll(result, this);
            return result;
        }

        private void recursiveGetAll(List<T> list, Quadtree<T> tree) {
            if (Value!= null) {
                list.Add(Value);
            }
            tree.Shsw?.recursiveGetAll(list, tree.Shsw);
            tree.Shgw?.recursiveGetAll(list, tree.Shgw);
            tree.Ghsw?.recursiveGetAll(list, tree.Ghsw);
            tree.Ghgw?.recursiveGetAll(list, tree.Ghgw);
        }

        public int GetCount() {
            int result = 0;
            result += Shsw?.GetCount() ?? 0;
            result += Shgw?.GetCount() ?? 0;
            result += Ghgw?.GetCount() ?? 0;
            result += Ghsw?.GetCount() ?? 0;
            return (Value != null && !Value.IsDeleted) ? ++result : 0;
        }
    }
}
