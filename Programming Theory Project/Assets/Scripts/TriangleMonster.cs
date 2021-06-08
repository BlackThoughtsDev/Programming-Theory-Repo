using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriangleMonster : MonsterClass
{
    private void Start()
    {
        size = 1.5f;
        speed = 9;
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
            SizeMultiplier();
        }
    }
}
