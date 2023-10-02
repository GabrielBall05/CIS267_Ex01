using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public int collectableValue;

    // Start is called before the first frame update
    void Start()
    {

    }

    public void destroyCollectable()
    {
        //Include this. so that we delete the collectable not something else
        Destroy(this.gameObject);
    }

    public int getCollectableValue()
    {
        return collectableValue;
    }

    public void setCollectableValue(int value)
    {
        collectableValue = value;
    }
}
