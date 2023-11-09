public class ShipHold<T> {
    private List<T> items = new List<T>();

    public void AddItem(T item) {
        items.Add(item);
    }


    public void RemoveItem(T item) {
        items.Remove(item);
    }


    public bool ContainsItem(T item) {
        return items.Contains(item);
    }

    public IEnumerable<T> GetItems() {
        return items;
    }
}