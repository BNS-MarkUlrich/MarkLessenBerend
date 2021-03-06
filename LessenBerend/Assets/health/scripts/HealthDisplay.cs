using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    private PlayerHealth _playerHealth;

    private float _playerTargetHealth;
    private float _playerTargetStartHealth;
    private float _playerBarHealth;
    public Text _playerHealthString;
    public Slider _playerHealthSlider;

    // Start is called before the first frame update
    void Awake()
    {
        _playerHealth = GetComponentInParent<PlayerHealth>();
        _playerTargetStartHealth = _playerHealth._startHealth;
        Debug.Log(_playerHealthString);
    }

    // Update is called once per frame
    void Update()
    {
        _playerTargetHealth = _playerHealth._currentHealth;

        _playerHealthString.text = " " + _playerTargetHealth;

        //bar calculations
        _playerBarHealth = _playerTargetHealth / _playerTargetStartHealth * 100;
        _playerHealthSlider.value = _playerBarHealth;
    }
}
