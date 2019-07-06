using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverSignController : MonoBehaviour
{
    // +++ fields +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
    [SerializeField] private TextMeshProUGUI _gameOverText;
    [SerializeField] private float _fadeInTime;
    [SerializeField] private int _steps;

    async void Start()
    {
        _gameOverText.color = new Color(1f,0.2121f, 0,0);
        for(float i = 0f; i<_fadeInTime; i+=_fadeInTime / _steps){
            Debug.Log(i);
            _gameOverText.color = new Color(1f,0.2121f, 0,(i/_fadeInTime));
           await System.Threading.Tasks.Task.Delay((int)(_fadeInTime * 1000) / _steps);
        }
    }
}
