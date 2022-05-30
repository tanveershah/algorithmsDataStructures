public class SingleLinkedList
{
  private Node head;
  private int count;

  public SingleLinkedList()
  {
    this.head = null;
    this.count = 0;
  }

  public bool IsEmpty
  {
    get { return this.count == 0; }
  }
  public int Count
  {
    get { return this.count; }
  }

  public object this[int index]
  {
    get { return this.GetDataByIndex(index); }
  }

  /// <summary>
  /// AddNode adds a node at a given index in the list
  /// </summary>
  /// <param name="index">add a node to the list at the index</param>
  /// <param name="data">contains the object to be added</param>
  /// <returns>returns the object added</returns>
  /// <exception cref="ArgumentOutOfRangeException">Index cannot be less than 0</exception>
  public object AddNode(int index, object data)
  {
    if (index < 0)
    {
      throw new ArgumentOutOfRangeException($"{nameof(index)} - {index}");
    }

    if (index > this.count)
    {
      index = this.count;
    }

    Node current = this.head;

    if (this.IsEmpty || index == 0)
    {
      this.head = new Node(data, this.head);
    }
    else
    {
      for (int i = 0; i < index - 1; i++)
      {
        current = current.Next;
      }

      current.Next = new Node(data, current.Next);
    }

    this.count++;

    return data;
  }

  /// <summary>
  /// AddNode is overloaded to add a node to the end of the list
  /// </summary>
  /// <param name="data">contains the object to be added</param>
  /// <returns>returns the object added</returns>
  public object AddNode(object data)
  {
    return AddNode(this.count, data);
  }

  /// <summary>
  /// removes a node at a give index
  /// </summary>
  /// <param name="index">specifies which node to be removed</param>
  /// <returns>returns the object from the removed node</returns>
  /// <exception cref="ArgumentOutOfRangeException">index cannot be less than 0</exception>
  public object RemoveNode(int index)
  {
    if (index < 0)
    {
      throw new ArgumentOutOfRangeException($"{nameof(index)} - {index}");
    }

    if (this.IsEmpty)
    {
      return null;
    }

    if (index >= this.count)
    {
      index = this.count - 1;
    }

    Node current = this.head;
    object removedItem = null;

    if (index == 0)
    {
      removedItem = current.Data;
      this.head = current.Next;
    }
    else
    {
      for (int i = 0; i < index - 1; i++)
      {
        current = current.Next;
      }
      removedItem = current.Next.Data;
      this.head = current.Next.Next;
    }

    this.count--;
    return removedItem;
  }

  /// <summary>
  /// clears the list by setting the head to null and count to 0
  /// </summary>
  public void ClearList()
  {
    this.head = null;
    this.count = 0;
  }

  /// <summary>
  /// returns the index of the node that contains the specific data
  /// </summary>
  /// <param name="data">specifies the data whose node index is being searched for</param>
  /// <returns>returns the index of node that contains the specific data or -1 if data is not found</returns>
  public int IndexOf(object data)
  {
    Node current = this.head;

    for (int i = 0; i < this.count; i++)
    {
      if (current.Data.Equals(data))
      {
        return i;
      }

      current = current.Next;
    }

    return -1;
  }

  /// <summary>
  /// checks if certain data exists or not
  /// </summary>
  /// <param name="data">data which is being searched in the list</param>
  /// <returns>returns true if certain data exists false otherwise</returns>
  public bool ContatinsData(object data)
  {
    return this.IndexOf(data) >= 0;
  }

  /// <summary>
  /// This method and the indexer propety enable to access the data in a node just like accessing an element in an array
  /// </summary>
  /// <param name="index">index of the node</param>
  /// <returns>returns data at a specific index</returns>
  /// <exception cref="ArgumentOutOfRangeException"></exception>
  public object GetDataByIndex(int index)
  {
    if (index < 0)
    {
      throw new ArgumentOutOfRangeException($"{nameof(index)} - {index}");
    }

    if (this.IsEmpty)
    {
      return null;
    }

    if (index >= this.count)
    {
      index = this.count - 1;
    }

    Node current = this.head;
    for (int i = 0; i < index; i++)
    {
      current = current.Next;
    }

    return current.Data;
  }

}
