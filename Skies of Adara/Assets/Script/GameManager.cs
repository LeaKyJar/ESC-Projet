﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public static GameManager instance = null;

    private bool preparationPhase = false;
    private bool atkPhase = false;
    private bool defPhase = false;
    //public ArrayList gridInfo;
    
    

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        } else if (instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Use this for initialization
    void Start () {
        enterPreparation();

    }
	
	// Update is called once per frame
	void Update () {
        
	}

    void endTurn ()
    {
        atkPhase = false;
        defPhase = true;
    }

    void startTurn ()
    {
        atkPhase = true;
        defPhase = false;
    }

    void enterPreparation()
    {
        preparationPhase = true;
    }

    void exitPreparation()
    {
        preparationPhase = false;
    }
}
