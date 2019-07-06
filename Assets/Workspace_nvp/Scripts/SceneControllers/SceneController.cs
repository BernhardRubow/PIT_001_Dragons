using System;
using System.Collections;
using System.Collections.Generic;
using nvp.Events;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // +++ fields +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    public Queue<string> _loadedScenes;

    // +++ life cycle +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    void Start()
    {
        Initialization();

        _loadedScenes.Enqueue("02_Splash");        
        SceneManager.LoadScene(_loadedScenes.Peek(),LoadSceneMode.Additive);

        EventController.SubscribeEvent("splash screen shown", OnSplashScreenShown);
        EventController.SubscribeEvent("start game", OnStartGame);
        EventController.SubscribeEvent("player killed", OnPlayerKilled);
    }


    // +++ life cycle +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    void Update()
    {
    
    }

    void OnDisable()
    {
        EventController.UnsubscribeEvent("splash screen shown", OnSplashScreenShown);            
    }




    // +++ class methods ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    private void LoadNewSceneAndRemovePrevious(string sceneName){
        
        if(_loadedScenes.Count > 0){
            string previousScene = _loadedScenes.Dequeue();
            SceneManager.UnloadSceneAsync(previousScene);
        }
        
        _loadedScenes.Enqueue(sceneName);
        SceneManager.LoadScene(_loadedScenes.Peek(), LoadSceneMode.Additive);
    }




    // +++ event handler ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    private void OnSplashScreenShown(object s, object e)
    {
        LoadNewSceneAndRemovePrevious("05_Menu");
    }

    private void OnStartGame(object arg1, object arg2)
    {
        LoadNewSceneAndRemovePrevious("10_Level_000");
    }

    private void Initialization()
    {
        _loadedScenes = new Queue<string>();
    }

    private void OnPlayerKilled(object arg1, object arg2)
    {
        LoadNewSceneAndRemovePrevious("04_GameOver");
    }
}
