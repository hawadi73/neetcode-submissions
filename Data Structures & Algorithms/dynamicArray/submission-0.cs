public class DynamicArray
{
    int[] array;
    int size;
    int capacity;

    public DynamicArray(int capacity)
    {
        this.capacity = capacity;
        this.size = 0;
        this.array = new int[capacity];
    }

    public int Get(int i)
    {
        return array[i];
    }

    public void Set(int i, int n)
    {
        array[i] = n;
    }

    public void PushBack(int n)
    {
        if (size == capacity)
        {
            Resize();
        }

        array[size] = n;
        size++;
    }

    public int PopBack()
    {
        size--;
        return array[size];
    }

    public void Resize()
    {
        capacity *= 2;
        int[] newArray = new int[capacity];

        for (int i = 0; i < size; i++)
        {
            newArray[i] = array[i];
        }

        array = newArray;
    }

    public int GetSize()
    {
        return size;
    }

    public int GetCapacity()
    {
        return capacity;
    }
}