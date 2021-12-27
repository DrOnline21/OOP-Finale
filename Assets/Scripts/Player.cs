using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    [SerializeField] private float playerSpeed = 8.0f;
    private readonly int playerHealthMax = 100;
    public int playerHealth { get; private set; } = 100; //Encapsulation
    public Text healthLeft;

    private void Start()
    {
        StartCoroutine(TimePass());
    }

    void Update()
    {
        Move(); //Abstraction
        healthLeft.text = "Health Left: " + playerHealth;
    }

    IEnumerator TimePass()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.2f);
            ReducePlayerHealth();

        }
    }
    private void ReducePlayerHealth()
    {
        playerHealth--;
        if (playerHealth < 0)
        {
            QuitGame();
        }
    }

    public void RestoreHealth()
    {
        playerHealth = playerHealthMax;
    }

    public void RestoreHealth(int hp)
    {
        playerHealth = playerHealth + hp;
    }
    public void LowerHealth(int hp)
    {
        playerHealth = playerHealth - hp;
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
    private void Move()
    {
        var horizontal = Input.GetAxis("Horizontal");
        //var vertical = Input.GetAxis("Vertical");

        var relocationX = Vector2.right * Time.deltaTime * horizontal * playerSpeed;
        //var relocationZ = Vector2.up * Time.deltaTime * vertical * playerSpeed;

        transform.Translate(relocationX);

        //transform.Translate(relocationZ);
    }
}
