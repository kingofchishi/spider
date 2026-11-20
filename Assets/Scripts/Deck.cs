using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deck
{
    List<Card> cards;
    /// <summary>
    /// 是否为空
    /// </summary>
    public bool isEmpty
    {
        get => cards.Count == 0;
    }
    /// <summary>
    /// 还剩多少
    /// </summary>
    public int leftCount
    {
        get => cards.Count;
    }
    /// <summary>
    /// 最顶上的卡牌
    /// </summary>
    public Card TopCard
    {
        get => cards[leftCount - 1];
    }
    /// <summary>
    /// 是否能放上去，如果是发牌，则不需要此验证
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public bool CanPut(Card other)
    {
        if (isEmpty) return true;
        if(other.Point == TopCard.Point + 1)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
    /// <summary>
    /// 把other牌放到牌堆顶
    /// </summary>
    /// <param name="other">准备放到顶上的牌</param>
    public void Put(Card other)
    {
        cards.Add(other);
    }
}
