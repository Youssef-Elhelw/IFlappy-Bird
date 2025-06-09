using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Bird_Fly : MonoBehaviour
{
    public Animator animator;
    Rigidbody2D rb;
    public int cnt = 0;
    bool die = false;
    public GameObject GameOver;
    public TextMeshProUGUI score;
    public AudioSource src;
    public AudioClip sfx0, sfx1;
    // Start is called before the first frame update
    void Start()
    {
        src.clip = sfx0;
        src.Play();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (die)
        {

            GameOver.SetActive(true);
            if (Input.GetKeyDown(KeyCode.A))
            {
                SceneManager.LoadScene(1);
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animator.Play("Player_Fly", -1, 0f);
                rb.velocity = Vector2.up * 5.8f;
            }
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Pipe") && !die)
        {
            die = true;
            src.clip = sfx1;
            src.Play();
        }
        else if (collision.CompareTag("Score") && !die)
        {
            cnt++;
            score.text = cnt.ToString();
        }
    }
}
