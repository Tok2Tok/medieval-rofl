using UnityEngine;

public class Player : MonoBehaviour 
{
    private PlayerState _playerState = PlayerState.None;

    public PlayerState currentState => _playerState;

    private void Start()
    {
        _playerState = PlayerState.Idle;
    }    

    public void SetState(PlayerState state)
    {
        _playerState = state;
    }
}