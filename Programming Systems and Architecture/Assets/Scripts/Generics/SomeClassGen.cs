using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClassGen <T>
{
    T item;
    public U GenericMethod<U>(U param)
    {
        return param;
    }

    public void UpdateItem(T newItem)
    {
        item = newItem;
        Debug.Log("Item set to " + newItem.ToString());
    }
}
