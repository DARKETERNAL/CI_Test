using UnityEngine;
using UnityEngine.UI;

public class BaseTester : MonoBehaviour
{
    [SerializeField]
    private Text label;

    [SerializeField]
    private string str = "Hello CI";

    // Start is called before the first frame update
    private void Start()
    {
        if (label != null)
        {
            label.text = str;
        }
        else
        {
            FindObjectOfType<Text>().text = "Nope CI";
        }
    }
}