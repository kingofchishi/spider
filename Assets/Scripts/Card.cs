using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{
    public bool isBackUp;
    public int Num;
    public SpriteRenderer sr;
    [SerializeField]
    Sprite up;
    [SerializeField]
    Sprite back;

    public int num2Point(int num)
    {
        return num % 13;
    }
    public int Point
    {
        get => Num % 13;
    }
    

    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
    }
    private void Update()
    {
        sr.sprite = isBackUp ? up : back;
    }
}
