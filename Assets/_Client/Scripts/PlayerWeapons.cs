using UnityEngine;

public class PlayerWeapons : MonoBehaviour 
{
    [SerializeField] private Animator _animator;
    [SerializeField] private Player _player;

    private void Attack()
    {
        if (_player.currentState == PlayerState.Idle)
        {
            _player.SetState(PlayerState.Attack);
            _animator.Play("Attack");
        }
    }

    private void Block()
    {
        _player.SetState(PlayerState.Block);
        _animator.Play("Block");
    }

    private void Unblock()
    {
        if (_player.currentState == PlayerState.Blocking)
        {
            _player.SetState(PlayerState.Unblock);
            _animator.Play("Unblock");
        }
    }

    private void Update() 
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Attack();
        }

        else if(Input.GetButtonDown("Fire2"))
        {
            Block();
        }

        else if(Input.GetButtonUp("Fire2"))
        {
            Unblock();
        }
    }    

    private void FinishAttack()
    {
        _player.SetState(PlayerState.Idle);
    }

    private void FinishBlock()
    {

    }

    private void StartBlocking()
    {

    }
}