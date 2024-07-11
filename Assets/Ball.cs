using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigidbody;

    
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>(); // Ball 오브젝트에 regidbody가 있다면 가져와라
        Launch();
    }

    private void Launch() // Ball이 시작되면 랜덤한 방향으로 날아간다
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        rigidbody.velocity = new Vector2(x* speed, y* speed);
    }

    public void Reset()
    {
        rigidbody.velocity = Vector2.zero;
        transform.position = Vector2.zero;
        Launch();
    }
}
