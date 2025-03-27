using UnityEngine;

/* [0] 개요 : Enemy
*/

namespace MyDefence
{

    public class Enemy : MonoBehaviour
    {
        // [1-1] 정의 : Field
        #region Field
        private float speed = 10f;
        private Vector3 targetPosition;
        private int wayPointIndex = 0;
        #endregion


        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-2] 정의 : 초기화.
            wayPointIndex = 0;
            targetPosition = WayPoints.wayPoints[wayPointIndex].position;
        }

        // Update is called once per frame
        void Update()
        {
            // [2-1] 가정 : Enemy의 이동구현.
            Vector3 dir = targetPosition - this.transform.position;
            transform.Translate(dir.normalized * Time.deltaTime*speed, Space.World);
            // [2-2] 가정 : Enemy의 도착구현 A.
            float distanceA = Vector3.Distance(targetPosition, this.transform.position);
            if (distanceA <= 0.1f)
            {
                targetPosition = WayPoints.wayPoints[1].position;
            }
            // [2-3] 가정 : Enemy의 도착구현 B.
            float distanceB = Vector3.Distance(targetPosition, this.transform.position);
            if (distanceB <= 0.1f)
            {
                targetPosition = WayPoints.wayPoints[2].position;
            }



        }
    }
}

// [1] 정의 : 
// [2] 가정 : 
// [3] 결과 : 


/*
 * 
 * 
                Debug.Log("도착");
                // [2-3] 가정 : Enemy의 이동구현 02.
 */