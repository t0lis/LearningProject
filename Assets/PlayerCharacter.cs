using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCharacter : MonoBehaviour
{
    public int _health;

    // Start is called before the first frame update
    void Start()
    {
        _health = 5;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void hurt(int damage)
    {
        _health -= damage;
        Debug.Log("Health " + _health);
    }
}
