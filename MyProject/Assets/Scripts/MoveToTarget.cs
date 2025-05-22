using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    public GameObject target;
    public GameObject target2;
    public float speed = 0.5f;

    Vector3 moveBuffer;

    // Start is called before the first frame update
    void Start()
    {
        movebro();
        moveBuffer = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        movebro();
    }

    private void MoveSelf()
    {
        Vector3 selfPos = transform.position;
        Vector3 targetPos = target.transform.position;
        Vector3 direction = targetPos - selfPos;
        float a = targetPos.x - selfPos.x;
        float b = targetPos.y - selfPos.y;
        float c = Mathf.Sqrt(a*a + b*b);
        Vector3 bro = direction / c;

        moveBuffer += bro * speed;
        transform.position = moveBuffer;

        Debug.Log(transform.position);
    }

    void MoveMath()
    {
        Vector3 direction = (target.transform.position - transform.position).normalized;
      
        moveBuffer += direction * speed;

        transform.position = moveBuffer;
    }

    void movebro()
    {
        Vector3 selfPos = transform.position;
        Vector3 targetPos = target.transform.position;
        Vector3 target2Pos = target2.transform.position;

        Vector3 boy = (target2Pos - targetPos) / 2f;

        moveBuffer = (targetPos + boy);
        transform.position = moveBuffer;
    }

}

    