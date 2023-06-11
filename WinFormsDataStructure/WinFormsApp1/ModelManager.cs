using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1 {
    public static class ModelManager {

        public static Box MakePurchase(string width, string height, string maxDifference, Quadtree<Box> tree) {
            int maxDifference1 = int.Parse(maxDifference);
            Box box = new Box() {
                Height = double.Parse(height),
                Width = double.Parse(width),
            };
            var (found, result) = tree.SearchByClosestSize(box, maxDifference1);
            if (found) {
                return result;
            } else return null;
        }

        public static void AskTheUserTheAmount(int amount, Box result, Quadtree<Box> tree) {
            if (result.Count - amount < 0) {
                result.Count = 0;
            } else {
                result.Count -= amount;
            }
            result.LastTimePurchased = DateTime.Now;
        }
        public static void AddABox(string widthInput, string heightInput, Quadtree<Box> tree) {
            double width = double.Parse(widthInput);
            double height = double.Parse(heightInput);
            tree.Add(new Box() { Height = height, Width = width });
        }
        public static void DeleteById(string id, Quadtree<Box> tree) {
            tree.Delete(int.Parse(id));
        }
    }
}
