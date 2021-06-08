using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMonster : MonsterClass
{
    private void Start()
    {
        size = 0.5f;
        speed = 2;
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
