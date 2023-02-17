using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GemUIUpdate : MonoBehaviour
{
    //private Text seashellCountText;
    private TextMeshProUGUI gemText;
    //private TriggerDetector seashellCollector;

    private void Start()
    {
        gemText = GetComponent<TextMeshProUGUI>();
        //seashellCollector = GetComponentInParent<TriggerDetector>();
    }

    public void UpdateGemText(TriggerDetector inventory)
    {
        gemText.text = "Ruby's Collected: "+inventory.gemCount.ToString()+"/5";
    }
}
