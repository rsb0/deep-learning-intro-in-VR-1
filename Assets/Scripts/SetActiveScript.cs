using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting;
using UnityEngine;
using Zinnia.Action;

public class SetActiveScript : MonoBehaviour
{
    public GameObject myObject;
    public bool activate;

    public BooleanAction ActivationAction;

    

    // Update is called once per frame
    void Update()
    {
        if (activate)
        {
            myObject.SetActive(true);
        }
        else
        {
            myObject.SetActive(false);
        }
    }
}
