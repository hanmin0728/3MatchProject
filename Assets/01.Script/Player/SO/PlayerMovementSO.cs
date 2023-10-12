using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/Player/Movement")]
public class PlayerMovementSO : ScriptableObject
{
    [Header("이동 관련")]
    public float speed = 4f;
}
