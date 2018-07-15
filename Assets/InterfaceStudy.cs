using UnityEngine;
using UnityEngine.UI;

public class InterfaceStudy : MonoBehaviour {
    int orangeCoin;
    public int OrangeCoin
    {
        get { return orangeCoin; }
        set
        {
            orangeCoin = Mathf.Clamp(value, 0, MaxOrangeCoin);
            orangeCoinText.text = orangeCoin.ToString("n0");
            orangeCoinSlider.value = orangeCoin;

        }
    }
    int maxOrangeCoin;
    public int MaxOrangeCoin
    {
        get { return maxOrangeCoin; }
        set
        {
            orangeCoinSlider.maxValue = value;
            maxOrangeCoin = value;
        }
    }
    public Text orangeCoinText;
    public Slider orangeCoinSlider;
    private void Awake()
    {
        MaxOrangeCoin = 100000;
    }
    public void GatherOrangeCoin()
    {
        OrangeCoin += 1000;
    }
}
