using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class TitleScreenScript : MonoBehaviour
{
    int score = 0;
    public TMP_Text scoreText;
    public GameObject canvasObject;

    public Image fadeImage;


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();

        fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, 0);

        // DontDestroyOnLoad(canvasObject);
        // DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            score++;
            scoreText.text = score.ToString();
        }

        if (Input.GetMouseButtonDown(0)) {
            StartCoroutine(FadeOutAndLoadScene());
        }
    }

    IEnumerator FadeOutAndLoadScene() {
        float fadeSpeed = 0.5f;
        while (fadeImage.color.a < 1) {
            float newAlpha = fadeImage.color.a + fadeSpeed * Time.deltaTime;
            fadeImage.color = new Color(fadeImage.color.r, fadeImage.color.g, fadeImage.color.b, newAlpha);
            yield return null;
        }

        // LOAD THE GAMEPLAY SCENE
        PlayerPrefs.SetInt("score", score);
        SceneManager.LoadScene("GameplayScene");
    }
}
