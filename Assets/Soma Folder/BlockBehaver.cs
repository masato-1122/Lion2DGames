using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehaver : MonoBehaviour
{
    // 何かとぶつかった時に呼ばれるビルトインメソッド
    void OnCollisionEnter(Collision collision)
    {
        // ゲームオブジェクトを削除するメソッド
        Destroy(gameObject);
    }

}
