using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{

    [SerializeField] private UnityEvent OnAttack = null;

    [SerializeField] private UnityEvent OnWeaponChange = null;

    [SerializeField] private UnityEvent OnInteract = null;


    private Player _player;

    private void Awake()
    {
        _player = GetComponent<Player>();
    }

    private void Update()
    {
        if (_player == null)
            return;
    }
}

