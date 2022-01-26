using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using IMovableClass;
using System.Linq;

public class MoveControllerScript : MonoBehaviour
{
    private List<IMovable> movables;

    void Start()
    {
        this.movables = new List<IMovable>();
    }

    public void Add(IMovable movable)
    {
        this.movables.Add(movable);
    }

    public void Remove(IMovable movable)
    {
        this.movables.Remove(movable);
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.movables.ForEach(x => x.MoveLeft());
        }
        if (Input.GetKey(KeyCode.D))
        {
            this.movables.ForEach(x => x.MoveRight());
        }
    }
}
