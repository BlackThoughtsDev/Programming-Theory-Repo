using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleMonster : MonsterClass
{
    private float size = 1.5f;


    private void Start()
    {
        NewTransform();
    }

    void Update()
    {
        GetAxis();
        Walk();
        DoAThing();
    }

    protected override void DoAThing()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            newtransform.localScale *= size;
        }
    }
}
