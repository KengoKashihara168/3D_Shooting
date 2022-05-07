using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    private Command leftArrow;
    private Command rightArrow;

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
            default:
                break;
        }
    }

    public Command HandleInput()
    {
        if(Input.GetKey(KeyCode.LeftArrow))  return leftArrow;
        if(Input.GetKey(KeyCode.RightArrow)) return rightArrow;

        return null;
    }
}
