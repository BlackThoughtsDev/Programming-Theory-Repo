using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMonster : MonsterClass
{
    private float size = 0.5f;

    private void Start()
    {
        newtransform = GetComponent<Transform>();
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
