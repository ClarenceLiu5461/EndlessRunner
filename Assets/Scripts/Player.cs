using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 3;
    public GameObject effect;
    public GameObject gameOver;
    public Text healthDisplay;

    private Vector2 targetPos;


    void Update()
    {
        healthDisplay.text = health.ToString();
        if (health <= 0)
        {
            gameOver.SetActive(true);
            Destroy(gameObject);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.UpArrow)&& transform.position.y < maxHeight)
        {
            Instantiate(effect,transform.position,Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)&& transform.position.y > minHeight)
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
        }
    }
}
