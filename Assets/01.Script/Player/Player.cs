using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] PlayerMovementSO _playerMovementSO;

    private Rigidbody2D _rid2D;
    private Collider2D _col2D;

    [SerializeField] private UnityEvent OnAttck;

    #region 이동 관련
    [SerializeField] private UnityEvent<Vector2> OnMove;

    private Vector2 _characterMoveAmount = Vector2.zero;
    public Vector2 CharacterMoveAmount => _characterMoveAmount;
    #endregion

    #region 캐싱 데이터
    private PlayerRenderer _playerRenderer = null;
    #endregion

    #region 프로퍼티
    public PlayerRenderer PlayerRenderer => _playerRenderer;
    #endregion

    void Awake()
    {
        _rid2D = GetComponent<Rigidbody2D>(); 
        _col2D = GetComponent<Collider2D>();

        _playerRenderer = transform.Find("AgentRenderer").GetComponent<PlayerRenderer>(); ;
    }

    private void Update()
    {
      
    }
    private void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        _characterMoveAmount = new Vector2(x, y);

        _characterMoveAmount = _characterMoveAmount.normalized;

        Debug.Log("플레이어 움직임 " + _characterMoveAmount);

        OnMove?.Invoke(_characterMoveAmount);

        _rid2D.velocity = _characterMoveAmount * _playerMovementSO.speed;
    }

    void Attack()
    {

        OnAttck?.Invoke();
    }
   
}
