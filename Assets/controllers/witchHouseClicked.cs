using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class witchHouseClicked : MonoBehaviour
{
    bool isLocked = true;

    private void OnMouseDown()
    {
        if (isLocked)
        {
            Debug.Log("OH NO! ITS LOCKED");
        }
        else
        {
            Debug.Log("Witch House has been stormed");
        }
    }

    public void setIsLocked(bool set)
    {
        isLocked = set;
    }

    public bool getIsLocked()
    {
        return isLocked;
    }

}
