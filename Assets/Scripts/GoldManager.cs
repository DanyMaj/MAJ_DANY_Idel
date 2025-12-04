using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Runtime.InteropServices;
using NUnit.Framework.Constraints;

public class GoldManager : MonoBehaviour
{
    public int goldAmount;
    public int power;
    public int powerPrice;
    public int timePower;
    public int timePrice;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI powerPriceText;
    public TextMeshProUGUI timePowerText;
    public TextMeshProUGUI timePowerPriceText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timePower = 0;
        timePrice = 100;
        power = 0;
        powerPrice = 10;
        StartCoroutine(autoGold()); 
    }

    public void ChangeGold()
    {
        goldAmount += power+1;
        goldText.text = goldAmount.ToString("00");
        goldAmount += timePower + 1;
    }


    public void LaunchCoroutine()
    {
        if (goldAmount >= timePrice)
        {
            goldAmount -= timePrice;
            goldText.text = goldAmount.ToString("00");
            timePrice = Mathf.CeilToInt(timePrice * 2.2f);

            timePower += 1;
        }
    }

    public void ChangePower()
    {
        if (goldAmount >= powerPrice)
        {
            goldAmount -= powerPrice;
            goldText.text = goldAmount.ToString("00");
            powerPrice = Mathf.CeilToInt(powerPrice * 2.2f);
            
            power += 1;
        }
    }

    public IEnumerator autoGold()
    {
    
        while (true)
        {
            goldAmount += timePrice;
            yield return new WaitForSeconds(10);
        }
    }


    // Update is called once per frame
    void Update()
    {
        powerPriceText.text = powerPrice.ToString("00");
        powerText.text = power.ToString("00");
        timePowerText.text = timePower.ToString("00"); 
        timePowerPriceText.text = timePrice.ToString("00");

        if (goldAmount >= 1000)
        {
            goldText.text = (goldAmount / 1000).ToString("00K");
        }
    }
}