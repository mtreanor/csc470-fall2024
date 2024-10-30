using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject popUpWindow;

    public TMP_Text nameText;
    public TMP_Text bioText;
    public TMP_Text statText;
    public Image portraitImage;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = "Mew Mew";
        bioText.text = "Mew Mew was raised on the mean street but has been indoors fo 15 years.";
        statText.text = "STRENGTH: 18";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClosePopUpWindow()
    {
        popUpWindow.SetActive(false);
    }
}
