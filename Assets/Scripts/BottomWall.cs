using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BottomWall : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        var ball = other.gameObject.GetComponent<Ball>();
        if (ball == null) return;

        ball.ResetPosition();
    }
}
