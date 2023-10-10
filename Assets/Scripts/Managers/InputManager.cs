using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager
{
    public Action KeyAction = null;
    public void OnUpdate()
    {
        if (Input.anyKey == false)
            return;

        // Unity Object는 ?(null) 연산자를 사용하면 에러가 발생한다.
        if (KeyAction != null )
            KeyAction.Invoke();

    }
}
