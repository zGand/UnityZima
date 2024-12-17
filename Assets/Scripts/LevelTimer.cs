using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelTimer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] int time;
    private GameObject player;

    void Start()
    {
        StartCoroutine(TimePass());
        player = GameObject.Find("Player");
        timerText.text = "Time: " + time;
    }

    private IEnumerator TimePass()
    {
        yield return new WaitForSeconds(1);
        time -= 1;
        timerText.text = "Time: "+time;

        if (time <= 0)
        {
            player.GetComponent<PlayerMovement>().isGameActive = false;
            StartCoroutine(LevelLose());
        }
        else
        {
            StartCoroutine(TimePass());
        }
    }

    private IEnumerator LevelLose()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
