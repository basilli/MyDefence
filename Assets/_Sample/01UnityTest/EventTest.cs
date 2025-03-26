using System;
using UnityEngine;

public class EventTest : MonoBehaviour
{
// [1] 정의 : Awake
    private void Awake()
    {
        Debug.Log("[1] Awake 실행");      // ) 딱 1번만 실행.
    }

// [2] 정의 : OnEnable
    private void OnEnable()
    {
        Debug.Log("[6-1] OnEnable 실행");      // ) (활성화 될 때) 1회 실행.
    }

// [3] 정의 : Start
    private void Start()
    {
        Debug.Log("[2] Start 실행");      // ) 딱 1번만 실행.
    }

// [4] 정의 : FixedUpdate
    private void FixedUpdate()
    {
        Debug.Log("[3] FixedUpdate 실행");      // ) 1초에 50프레임 고정.
    }

// [5] 정의 : Update
    private void Update()
    {
        Debug.Log("[4] Update 실행");      // ) 매 프레임마다 호출. → 연산량에 따라서 속도가 달라짐.
    }

// [6] 정의 : LateUpdate
    private void LateUpdate()
    {
        Debug.Log("[5] LateUpdate 실행");     // ) Update() 실행 뒤에 바로 따라서 실행함.
    }

// [7] 정의 : OnDisable
    private void OnDisable()
    {
        Debug.Log("[6-2] OnDisable 실행");      // ) (비활성화될 때) 1회 실행.
    }

// [8] 정의 : OnDestroy
    private void OnDestroy()
    {
        Debug.Log("[7] OnDestroy 실행");      // ) 1회만 실행.
    }
}
