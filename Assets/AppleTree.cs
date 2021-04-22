using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    // ������ ��� �������� �����
    public GameObject applePrefab;

    // �������� �������� ������
    public float speed = 1f;

    // ����������, �� ������� ������ ���������� ����������� �������� ������
    public float leftAndRightEdge = 10f;

    public float chanceToChangeDirections = 1f;

    // ������� �������� ����������� �����
    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        // ���������� ������ ��� � �������
        Invoke("DropApple", secondsBetweenAppleDrops);
        speed = speed * ApplePicker.level;
        secondsBetweenAppleDrops = ApplePicker.appleSpeed;
    }

    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", secondsBetweenAppleDrops);
    }

    // Update is called once per frame
    void Update()
    {
        // ������� �����������
        Vector3 pos = transform.position;
        pos.x += this.speed * Time.deltaTime;
        transform.position = pos;

        // ��������� �����������
        if (pos.x < -this.leftAndRightEdge)
        {
            this.speed = Mathf.Abs(speed);  // ������ �������� ������
        }
        else if (pos.x > this.leftAndRightEdge)
        {
            this.speed = -Mathf.Abs(speed);  // ������ �������� �����
        }
    }

    void FixedUpdate()
    {
        // ������ ��������� ����� ����������� ��������� �� �������,
        // ������ ��� ����������� � FixedUpdate()
        if (Random.value < this.chanceToChangeDirections)
        {
            this.speed *= -1;
        }
    }
}
