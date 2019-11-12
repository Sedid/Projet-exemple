using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{

    public Transform monPetitTexte;
    public Transform trucInvisible;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void testBouton()
    {
        print("click");
        monPetitTexte.GetComponent<Text>().text = "j\'ai changé le texte";
        trucInvisible.gameObject.SetActive(false);
    }

}
