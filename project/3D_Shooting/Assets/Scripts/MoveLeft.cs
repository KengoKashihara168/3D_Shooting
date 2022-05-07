using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : Command
{
    private Rigidbody rigidBody;

    // 実行
    public override void Execute(GameObject gameObject)
    {
        // 初回実行時にRigidBodyを取得
        if(rigidBody)
        {
            rigidBody = gameObject.GetComponent<Rigidbody>();
        }

        Move();
    }

    // 移動
    private void Move()
    {
        Debug.Log("左へ動く");
    }
}
