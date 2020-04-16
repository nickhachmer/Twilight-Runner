﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenuBehavior : MonoBehaviour
{
    

    public GameObject PauseMenu;
    public GameObject OptionsMenu;

    void Awake() {
        if (PauseMenu == null) {
            PauseMenu = GameObject.Find("PauseMenu");
        }
        if (OptionsMenu == null) {
            OptionsMenu = GameObject.Find("OptionsMenu");
        }
    }

    void Start() {
        PauseMenu.SetActive(false);
        OptionsMenu.SetActive(false);
    }


    #region Pause Menu

    public void PauseMenu_Button_Resume() {
        PauseMenu.SetActive(false);
    }

    public void PauseMenu_Button_Options() {
        MenuController.Transition(PauseMenu, OptionsMenu);
    }

    public void PauseMenu_Button_ExitToMenu() {
        MenuController.LoadScene(0);
    }

    #endregion

    #region Options Menu

    public void OptionsMenu_Button_Back() {
        MenuController.Transition(OptionsMenu, PauseMenu);
    }

    #endregion
}
