using UnityEngine;

public class Player : MonoBehaviour 
{
    private PlayerState _playerState = PlayerState.None;

    private void Start()
    {
        _playerState = PlayerState.Idle;
    }    

    private PlayerState GetState()
    {
        return _playerState;    
    }

    public void SetState(PlayerState state)
    {
        _playerState = state;
    }
}