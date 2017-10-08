using System;
using UnityEngine;

public class newclass : MonoBehaviour
{
    void Start()
    {
        MoveToPos(SetScale());
    }
    /////
    public void MoveToPos(Action oncomplete)
    {
        //..../
        oncomplete.Invoke();
    }
    public Action SetScale(Action oncomplete = null)
    {
        // ....
        oncomplete.Invoke();
        return null;
    }


}