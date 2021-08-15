using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    void Start()
    {
        name="Sphere";
        color="BLUE";

    }

    public override void DisplayText()
    {
        base.DisplayText();
        Debug.Log(id);
        Debug.Log(color);
    }
}
