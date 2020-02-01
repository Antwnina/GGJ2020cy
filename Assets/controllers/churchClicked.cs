using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class churchClicked : MonoBehaviour
{
    bool isLocked = false;

    void OnMouseDown()
    {
        if (isLocked)
        {
            Debug.Log("OH NO! ITS LOCKED");
        }
        else
        {
            Debug.Log("Church House has been stormed");
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
