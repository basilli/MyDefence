using UnityEngine;

/* [0] 개요 : MoveTest
		- 전후좌우로 이동.
		- 5의 속도로 이동.
		- 목표지점(7,1,8)으로 이동.
		- 목표지점 도착판정.
		- 1Unit(단위)
            
        - n 프레임 : 프레임을 초당 n번 실행.
            - 20 프레임 : 1프레임을 보여주는데 0.05초가 걸림.
            - FPS : 1초에 보여주는 프레임 n수.

        - Unity
            Time.deltaTime : 1프레임을 실행하는데 걸리는 시간.

        - PC1 : 성능이 좋은 PC → 10프레임.
            - Time.deltaTime 값 : 0.1f
            - this.transform.position = this.transform.position + new Vector3(0f, 0f, 1f) * Time.deltaTime * 20; → 1초에 10만큼 앞으로 이동.

        - PC2 : 성능이 안좋은 PC → 2프레임.
            - Time.deltaTime 값 : 0.5f
            - this.transform.position = this.transform.position + new Vector3(0f, 0f, 1f)* Time.deltaTime * 20; → 1초에 2만큼 앞으로 이동.

        - 방향 * 속도 * Time.deltaTime
*/

namespace Sample
{

    public class MoveTest : MonoBehaviour
    {
        // [1-1] 정의 : Field → 목표 지점(7,1,8) 생성.
        Vector3 targetPosition = new Vector3(7f,1f,8f);

        // [2-1] 정의 : 5의 속도로 이동.
        private float speed = 5f;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            // [1-2] 가정 및 결과 : this.transform 위치지정. → MoveTest Class가 붙어있는 게임오브젝트의 인스턴스.
            // ) this.transform.position = new Vector3(7f, 1f, 8f); → OK.
            // ) this.transform.position = targetPosition; → OK.
            // ) Debug.Log(this.transform.position); → OK.
        }

        // Update is called once per frame
        void Update()
        {
            // [1-3] 가정 및 결과 : Player의 위치를 앞으로 이동.
            // ) this.transform.position.z = this.transform.position.z + 1; → NG.
            // ) this.transform.position = this.transform.position + new Vector3(0f, 0f, 1f);

            // [1-4] 가정 및 결과 : Player의 위치를 전후좌우상하로 이동.
            // ) this.transform.position = this.transform.position + new Vector3(0f, 0f, 1f); → 전 OK.
            // ) this.transform.position = this.transform.position + new Vector3(0f, 0f, -1f); → 후 OK.
            // )this.transform.position = this.transform.position + new Vector3(-1f, 0f, 0f); → 좌 OK.
            // ) this.transform.position = this.transform.position + new Vector3(1f, 0f, 0f); → 우 OK.
            // ) this.transform.position = this.transform.position + new Vector3(0f, 1f, 0f); → 상 OK.
            // ) this.transform.position = this.transform.position + new Vector3(0f, -1f, 0f); → 하 OK.
            // ) Debug.Log(this.transform.position);

            // [1-5] 가정 및 결과 : 다른 명령으로 Player의 위치를 전후좌우상하로 이동.
            // ) this.transform.position += Vector3.forward; → 전 OK.
            // )this.transform.position += Vector3.back; → 후 OK.
            // ) this.transform.position += Vector3.left; → 좌 OK.
            // ) this.transform.position += Vector3.right; → 우 OK.
            // ) this.transform.position += Vector3.up; → 상 OK.
            // ) this.transform.position += Vector3.down; → 하 OK.



            // [2-2] 가정 : 앞으로 1초에 1uni만큼 이동.
            // ) this.transform.position += new Vector3(0f, 0f, 1f) * 1 * Time.deltaTime; → OK.

            // [2-3] 가정 : 앞으로 1초에 speed(5)unit만큼 이동.
            // ) this.transform.position += Vector3.forward * speed * Time.deltaTime; → OK.

            // [2-4] 가정 : Translate(이동함수)
            /*
                - 방향 : 전방
                - Time.deltaTime : 동일한 시간에 동일한 거리를 이동하게 해줌.
                - speed : 이동속도, 초당 이동하는 거리.
                - Vector3 * float(=Time.deltaTime) * float(=speed) → Vector3.
             */
            // ) this.transform.Translate(Vector3.forward* Time.deltaTime * speed); → 전 OK.
            // ) this.transform.Translate(Vector3.back * Time.deltaTime * speed); → 후 OK.
            // ) this.transform.Translate(Vector3.left * Time.deltaTime * speed); → 좌 OK.
            // ) this.transform.Translate(Vector3.right * Time.deltaTime * speed); → 우 OK.

            // [2-5] 가정 : 방향 구하기
            /*
                - (목표위치 - 현재위치),(목표위치 - 현재위치).normalized
                - dir.magnitude : 백터의 크기, 길이
                - dir.normalized : 길이가 1인 벡터, 정규화된 벡터, 단위벡터
             */
            // ) Vector3 dir = targetPosition - this.transform.position; → OK.
            // ) transform.Translate(dir.normalized * Time.deltaTime * speed); → OK.



            // [3-1] 가정 : Space.World, Space.Self
            // ) transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.World); → World의 Z방향을 향하여 앞으로 이동.
            // ) transform.Translate(Vector3.forward * Time.deltaTime * speed, Space.Self); → Self의 Z방향을 향하여 앞으로 이동.
        }
    }
}