using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GoldManager : MonoBehaviour
{
    public int goldAmount;
    public int power;
    public int powerPrice;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI powerGoldText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        power = 1;
        powerPrice = 10;
    }

    public void ChangeGold()
    {
        goldAmount += power;
        goldText.text = goldAmount.ToString("00");
    }

    public void ChangePower()
    {
        if (goldAmount >= powerPrice)
        {
            goldAmount -= powerPrice;
            goldText.text = goldAmount.ToString("00");
            powerPrice = Mathf.CeilToInt(powerPrice * 2.2f);
            powerText.text = goldAmount.ToString("00");
            powerGoldText.text = goldAmount.ToString("00");
            power += 1;
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}