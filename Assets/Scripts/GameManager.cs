using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public static GameManager Instance
    {
        get => instance;
    }
    /// <summary>
    /// 十个牌堆
    /// </summary>
    Deck[] decks = new Deck[10];
    /// <summary>
    /// 收集14张牌
    /// </summary>
    [SerializeField]
    Card[] cards = new Card[104];


}
