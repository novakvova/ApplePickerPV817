using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Set in Inspector")]
    // Шаблон для создания яблок
    public GameObject applePrefab;

    // Скорость движения яблони
    public float speed = 1f;

    // Расстояние, на котором должно изменяться направление движения яблони
    public float leftAndRightEdge = 10f;

    public float chanceToChangeDirections = 1f;

    // Частота создания экземпляров яблок
    public float secondsBetweenAppleDrops = 1f;

    // Start is called before the first frame update
    void Start()
    {
        // Сбрасывать яблоки раз в секунду
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
        // Простое перемещение
        Vector3 pos = transform.position;
        pos.x += this.speed * Time.deltaTime;
        transform.position = pos;

        // Изменение направления
        if (pos.x < -this.leftAndRightEdge)
        {
            this.speed = Mathf.Abs(speed);  // Начать движение вправо
        }
        else if (pos.x > this.leftAndRightEdge)
        {
            this.speed = -Mathf.Abs(speed);  // Начать движение влево
        }
    }

    void FixedUpdate()
    {
        // Теперь случайная смена направления привязана ко времени,
        // потому что выполняется в FixedUpdate()
        if (Random.value < this.chanceToChangeDirections)
        {
            this.speed *= -1;
        }
    }
}
