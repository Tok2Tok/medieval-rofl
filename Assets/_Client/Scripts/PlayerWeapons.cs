using UnityEngine;

public class PlayerWeapons : MonoBehaviour 
{
    [SerializeField] private Animator _animator;


    private void Attack()
    {
        _animator.Play("Attack");
    }

    private void Block()
    {
        _animator.Play("Attack");
    }

    private void Unblock()
    {
        _animator.Play("Unblock");
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

        else if(Input.GetButtonDown("Fire2"))
        {
            Unblock();
        }
    }    
}