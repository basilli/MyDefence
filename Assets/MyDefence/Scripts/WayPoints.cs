using UnityEngine;

/* [0] 개요 : WayPoints
*/

namespace MyDefence
{
    public class WayPoints : MonoBehaviour
    {
        // [1-1] 정의 : Field
        #region Field
        public static Transform[] wayPoints;
        #endregion

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-2] 가정 : Field 초기화.
            wayPoints = new Transform[this.transform.childCount];
            for (int i = 0; i < wayPoints.Length; i++)
            {
                wayPoints[i] = this.transform.GetChild(i);
                // [3] 결과 : 
                Debug.Log($"{wayPoints[i].position}");
            }
        }
    }
}