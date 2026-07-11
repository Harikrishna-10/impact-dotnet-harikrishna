using System.Collections.Generic;

public class Repository<T> where T : class, new()
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public void Update(int index, T item)
    {
        if (index >= 0 && index < items.Count)
            items[index] = item;
    }

    public void Delete(int index)
    {
        if (index >= 0 && index < items.Count)
            items.RemoveAt(index);
    }

    public List<T> GetAll()
    {
        return items;
    }
}