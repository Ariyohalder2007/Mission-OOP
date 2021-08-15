using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    // Start is called before the first frame update
    void Start()
    {
        name="Cube";
        color="RED";

    }

    public override void DisplayText()
    {
        base.DisplayText();
        Debug.Log(id);
        Debug.Log(color);
    }
}
