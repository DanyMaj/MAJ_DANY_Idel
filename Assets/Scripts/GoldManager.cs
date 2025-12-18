using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;
using System.Runtime.InteropServices;
using NUnit.Framework.Constraints;

public class GoldManager : MonoBehaviour
{
    public float goldAmount;
    public int power;
    public int timeGold;
    public bool shouldGoldRiseWithTime;
    public int powerPrice;
    public int timePower;
    public int timePower2;
    public int timePower3;
    public int timePrice;
    public int timePrice2;
    public int timePrice3;
    public TextMeshProUGUI goldText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI powerPriceText;
    public TextMeshProUGUI timePowerText;
    public TextMeshProUGUI timePower2Text;
    public TextMeshProUGUI timePower3Text;
    public TextMeshProUGUI timePowerPriceText;
    public TextMeshProUGUI timePowerPrice2Text;
    public TextMeshProUGUI timePowerPrice3Text;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        timePower = 0;
        timePower2 = 0;
        timePower3 = 0;
        timeGold = 0;
        timePrice = 100;
        timePrice2 = 500;
        timePrice3 = 1200;
        power = 0;
        powerPrice = 10;
        StartCoroutine(autoGold());
        
    }

    public void ChangeGold()
    {
        goldAmount += power+1;
    }


    public void LaunchCoroutine()
    {
  
        if (goldAmount >= timePrice)
        {
            shouldGoldRiseWithTime = true;
            goldAmount -= timePrice;
            timePrice = Mathf.CeilToInt(timePrice * 2.2f);
            timeGold += 50;
            timePower += 1;
        }
    }

    public void LaunchCoroutine2()
    {

        if (goldAmount >= timePrice2)
        {
            shouldGoldRiseWithTime = true;
            goldAmount -= timePrice2;
            timePrice2 = Mathf.CeilToInt(timePrice2 * 2.2f);
            timeGold += 200;
            timePower2 += 1;
        }
    }
    public void LaunchCoroutine3()
    {

        if (goldAmount >= timePrice3)
        {
            shouldGoldRiseWithTime = true;
            goldAmount -= timePrice3;
            timePrice3 = Mathf.CeilToInt(timePrice3 * 2.2f);
            timeGold += 500;
            timePower2 += 1;
        }
    }

    public void ChangePower()
    {
        if (goldAmount >= powerPrice)
        {
            goldAmount -= powerPrice;
            powerPrice = Mathf.CeilToInt(powerPrice * 2.2f);
            power += 1;
        }
    }

    public IEnumerator autoGold()
    {
        while (true)
        {
            yield return new WaitForSeconds(5);
            if(shouldGoldRiseWithTime)
            {
                goldAmount += timeGold;
            }
        }
    }


    private string goldTextTemp;
    // Update is called once per frame
    void Update()
    {


        if(goldAmount>=1000)
        {
            goldTextTemp = ((float)goldAmount / 1000f).ToString("0.0K");
        }
        else
        {
            goldTextTemp = goldAmount.ToString("0");
        }

        if(goldAmount >= 1000000)
        {
            goldTextTemp = ((float)goldAmount / 1000000f).ToString("0.0M");
        }

        if (goldAmount >= 1000000000)
        {
            goldTextTemp = ((float)goldAmount / 1000000000f).ToString("0.0Md");
        }

        if (goldAmount >= 1000000000000)
        {
            goldTextTemp = ((float)goldAmount / 1000000000000f).ToString("0.0Bn");
        }

        if (goldAmount >= 1000000000000000)
        {
            goldTextTemp = ((float)goldAmount / 1000000000000000f).ToString("0.0Bd");
        }

        if (goldAmount >= 1000000000000000000)
        {
            goldTextTemp = ((float)goldAmount / 1000000000000000000f).ToString("0.0Tn");
        }

        //if (goldAmount >= 1000000000000000000000)
        {
            //goldTextTemp = ((float)goldAmount / 1000000000000000000000f).ToString("0.0Td");
        }

        goldText.text = goldTextTemp;

        powerPriceText.text = powerPrice.ToString("0");
        powerText.text = power.ToString("0");
        timePowerText.text = timePower.ToString("0");
        timePowerPriceText.text = timePrice.ToString("0");
        timePowerPrice2Text.text = timePrice2.ToString("0");
        timePower2Text.text = timePower2.ToString("0");
        timePowerPrice3Text.text = timePrice3.ToString("0");
        timePower3Text.text = timePower3.ToString("0");
    }

}
