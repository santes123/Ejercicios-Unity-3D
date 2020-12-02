using UnityEngine;

public class cube_move : MonoBehaviour
{
    [SerializeField] private int numero = 1;
    private float numero2;
    private bool verdadero = true;
    private string nombre = "Antonio";



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(numero);
        Debug.Log("mi nombre es : " + nombre + "Gonzalez");

        numero += 3; //numero = numero + 3;
        numero -= 3; //numero = numero - 3;
        numero++;
        numero--;

        Debug.Log(numero);
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(numero);
        numero++;
    }
}
