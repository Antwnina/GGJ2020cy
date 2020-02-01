using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    public void btnQ()
    {
        Debug.Log("exit");
        Application.Quit();
    }
}
