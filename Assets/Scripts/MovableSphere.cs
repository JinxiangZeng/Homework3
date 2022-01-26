using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovableSphere : MovableShape
{
    public override void MoveLeft()
    {
        this.transform.Translate(Vector3.left * Time.deltaTime);
    }

    public override void MoveRight()
    {
        this.transform.Translate(Vector3.right * Time.deltaTime);
    }
}
