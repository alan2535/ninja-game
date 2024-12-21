using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Cat : MonoBehaviour
{
    public GameManager gameManager;
    public int life = 10;
    void Start()
    {
    }
    void Update()
    {
        // 點擊左方向鈕時
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(-3, 0, 0); // 往左移動「3」
        }
        // 點擊左方向鈕時
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(3, 0, 0); // 往右移動「3」
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 判斷碰撞的碰撞體有沒有帶有標籤「Arrow」
        if (collision.gameObject.tag == "Arrow")
        {
            gameManager.DecreaseHp();
            life -= 1;
            if (life <= 0)
                Destroy(gameObject);
        }
    }
    public void LButtonDown()
    {
        transform.Translate(-3, 0, 0);
    }
    public void RButtonDown()
    {
        transform.Translate(3, 0, 0);
    }

}