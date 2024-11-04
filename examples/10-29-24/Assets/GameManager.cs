using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public UnitScript selectedUnit;

    public List<UnitScript> units = new List<UnitScript>();

    public GameObject popUpWindow;

    public TMP_Text nameText;
    public TMP_Text bioText;
    public TMP_Text statText;
    public Image portraitImage;


    void OnEnable() 
    {
        if (GameManager.instance == null) {
            GameManager.instance = this;
        } else {
            Destroy(this);
        }
    }

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

    public void OpenCharacterSheet()
    {
        if (selectedUnit == null) return;
        
        nameText.text = selectedUnit.unitName;
        bioText.text = selectedUnit.bio;
        statText.text = selectedUnit.stats;

        popUpWindow.SetActive(true);
    }

    public void SelectUnit(UnitScript unit)
    {
        // deselect all of the units
        foreach(UnitScript u in units)
        {
            u.selected = false;
            u.bodyRenderer.material.color = u.normalColor;
        }

        // Select the new unit
        selectedUnit = unit;

        unit.selected = true;
        unit.bodyRenderer.material.color = unit.selectedColor;
    }

    public void ClosePopUpWindow()
    {
        popUpWindow.SetActive(false);
    }
}
