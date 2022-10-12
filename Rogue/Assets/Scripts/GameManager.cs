using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int key;
    public int gem;

    public void AddKey(int amount)
    {
        key += amount;
        Debug.Log("Keys = "+ key);
    }
    public void AddGem(int amount)
    {
        gem += amount;
        Debug.Log("Gems = "+ gem);
    }
}
