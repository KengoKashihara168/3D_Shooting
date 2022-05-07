using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Command leftArrow;
    private Command rightArrow;
    private Command upArrow;
    private Command downArrow;

    public void SetCommand(Command command,KeyCode key)
    {
        switch(key)
        {
            case KeyCode.LeftArrow:
                leftArrow = command;
                break;
            case KeyCode.RightArrow:
                rightArrow = command;
                break;
            case KeyCode.UpArrow:
                upArrow = command;
                break;
            case KeyCode.DownArrow:
                downArrow = command;
                break;
            default:
                break;
        }
    }

    public Command HandleInput()
    {
        if(Input.GetKey(KeyCode.LeftArrow))  return leftArrow;
        if(Input.GetKey(KeyCode.RightArrow)) return rightArrow;
        if(Input.GetKey(KeyCode.UpArrow))    return upArrow;
        if(Input.GetKey(KeyCode.DownArrow))  return downArrow;

        return null;
    }
}
