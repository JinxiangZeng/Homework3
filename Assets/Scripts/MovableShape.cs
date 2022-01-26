using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IMovableClass;
using System.Linq;

public abstract class MovableShape : MonoBehaviour, IMovable
{
    private int count;

    void Start()
    {
        this.count = 0;
    }
    public void OnMouseDown()
    {
        if (this.count == 0)
        {
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.SetColor("_Color", Color.red);

            GameObject gameObject = GameObject.Find("MoveController");
            gameObject.GetComponent<MoveControllerScript>().Add(this);

            this.count++;
        } else
        {
            Renderer renderer = GetComponent<Renderer>();
            renderer.material.SetColor("_Color", Color.white);

            GameObject gameObject = GameObject.Find("MoveController");
            gameObject.GetComponent<MoveControllerScript>().Remove(this);

            this.count = 0;
        }
        

    }

    public abstract void MoveLeft();

    public abstract void MoveRight();
}
