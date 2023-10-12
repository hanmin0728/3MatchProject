using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRenderer : MonoBehaviour
{
    private Player _player = null;

    private bool _fliped = false;
    public bool Fliped => _fliped;

    public void Flip(Vector2 dir)
    {
        if (dir.x == 0f)
            return;

        DirectionType flipDir = DirectionType.None;

        if (dir.x > 0f)
            flipDir = DirectionType.Right;
        else if (dir.x < 0f)
            flipDir = DirectionType.Left;
        else
            flipDir = _fliped ? DirectionType.Left : DirectionType.Right;

        if (flipDir == DirectionType.Left)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else if (flipDir == DirectionType.Right)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }

        _fliped = flipDir == DirectionType.Left;
    }
}
