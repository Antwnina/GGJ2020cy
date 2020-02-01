using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tavernClicked : MonoBehaviour
{
    bool isLocked = false;

    void OnMouseDown()
    {
        //set the witch house to enable, the user can now use this house
        witchHouseClicked witchScript = gameObject.GetComponent<witchHouseClicked>();
        witchScript.setIsLocked(false);

        if (isLocked)
        {
            Debug.Log("OH NO! ITS LOCKED");
        }
        else
        {
            Debug.Log("Tavern has been stormed");
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
