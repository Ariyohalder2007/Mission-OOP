using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Capsule : Shape
{
    void Start()
    {
        name="Capsule";
        color="GREEN";

    }

    public override void DisplayText()
    {
        base.DisplayText();
        Debug.Log(id);
        Debug.Log(color);
    }
}
