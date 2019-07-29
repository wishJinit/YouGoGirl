﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scrollobject : MonoBehaviour
{

    public float speed = 1.0f;
    public float startPosition;
    public float endPosition;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(1 * speed * Time.deltaTime, 0, 0);
        if (transform.position.x >= endPosition) scrollEnd();
    }

    private void scrollEnd()
    {
        transform.Translate(-1 * (endPosition - startPosition), 0, 0);
        SendMessage("OnScrollEnd", SendMessageOptions.DontRequireReceiver);
    }
}
