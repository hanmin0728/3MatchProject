using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerAnimation : MonoBehaviour
{
    private Animator _animator = null;

    private Player _player = null;

    void Awake()
    {
        _player = GetComponentInParent<Player>();
        _animator = GetComponent<Animator>();
    }

    public void MoveAnimation(Vector2 input)
    {
        if (Mathf.Abs(input.x) > 0f || Mathf.Abs(input.y) > 0f)
        {
            Debug.Log("��ũ�ִϸ��̼� ����");
            _animator.SetBool("Walk", true);
        }
        else
        {
            Debug.Log("���̵�ִϸ��̼� ����");
            _animator.SetBool("Walk", false);
        }

        _player.PlayerRenderer.Flip(input);
    }
}
