 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class DeadPlayer : MonoBehaviour
{
    public AudioEvent Coin;
    public AudioSource audio;
    public event Action DeadGroundPlayer;
    public event Action DiePlayer;

    PlayGameScore playGameScore;
   
    Rigidbody2D rb;

    PlayerController playerController;
    CameraShake cameraShake;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        cameraShake = FindObjectOfType<CameraShake>();
        playerController = GetComponent<PlayerController>();

        playGameScore = FindObjectOfType<PlayGameScore>();
        FindObjectOfType<DeadZoneSky>().DieZoneSky += DeadSky;
        FindObjectOfType<DeadZoneGround>().DieZoneGround += DeadGround;
    }
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemies"))
        {
            DeadByEnemy();
        }
        if (collision.gameObject.CompareTag("Coin"))
        {
            collision.GetComponent<IScoreCoin>()?.Score();
         
            collision.gameObject.SetActive(false);
            Coin.Play(audio);
        }
        
    }

    public void DeadSky()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Dynamic;
        var groundZone = FindObjectOfType<DeadZoneGround>();
        groundZone.gameObject.SetActive(false);
        Dead();
    }

    public void DeadGround()
    {
        Dead();
        DeadGroundPlayer?.Invoke();
    }

    void DeadByEnemy()
    {
        Dead();
    }

    void Dead()
    {
        playGameScore.SendScore();
        playerController.enabled = false;
        DiePlayer?.Invoke();
        StartCoroutine(TimerestarGame());
    }

    IEnumerator TimerestarGame()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
