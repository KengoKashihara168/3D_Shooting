using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static readonly float MoveSpeed = 2000.0f;
    public static readonly float MaxSpeed = 50.0f;
    [SerializeField] private InputHandler inputHandler;

    private void Start()
    {
        Command moveLeft  =  gameObject.AddComponent<MoveLeft>();
        Command moveRight =  gameObject.AddComponent<MoveRight>();
        inputHandler.SetCommand(moveLeft,KeyCode.LeftArrow);
        inputHandler.SetCommand(moveRight,KeyCode.RightArrow);
    }

    private void Update()
    {
        Command command = inputHandler.HandleInput();
        if(command)
        {
            command.Execute(gameObject);
        }
    }
}
