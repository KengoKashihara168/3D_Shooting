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
        Command moveUp    =  gameObject.AddComponent<MoveUp>();
        Command moveDown  =  gameObject.AddComponent<MoveDown>();
        inputHandler.SetCommand(moveLeft,KeyCode.LeftArrow);
        inputHandler.SetCommand(moveRight,KeyCode.RightArrow);
        inputHandler.SetCommand(moveUp,KeyCode.UpArrow);
        inputHandler.SetCommand(moveDown,KeyCode.DownArrow);
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
