using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControl : MonoBehaviour
{
    public ManagerGame gameManager;
    public ItemController itemController;
    public bool ImDead = false;

    //---------------------------------------------------Sergio
    private Rigidbody rb;
    public float speedMove = 5f;
    public float jumpForce = 5f;
    float horizontalInput;
    float verticalImput;
    public bool isOnGround;

    //---------------------------------------------------- Santiago
    int contador;
    public Text gemas;
    public SceneSelect managmentEscenas;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalImput = Input.GetAxis("Vertical");
        
        transform.Translate(Vector3.right * Time.deltaTime * speedMove * horizontalInput);

        transform.Translate(Vector3.forward * Time.deltaTime * speedMove * verticalImput);
        

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }

     private void ActualizarGemas() 
    {
       gemas.text = "Gemas: " + contador + "/10";
    }
    
        public void Awake()
    {
    contador = 0; 
    ActualizarGemas(); 
    }

     public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject); //Destruye objeto collider con el player tenga contacto
        itemController.ActualizarMarcador();
        /*contador = contador + 1; // cada vez que el player tenga contacto con uno collider se le sumara +1 a variable contador
        ActualizarGemas(); // metodo generado mas abajo para no repetir codigo, es solo llamarlo para que haga su trabajo
        if(contador >= 10) // Si contador es mayor o igual a 10 entonces
        {
            //win.gameObject.SetActive(true);
           managmentEscenas.menu(); //cargue nuevemente escena, "SampleScene" Nombre de escena creada en unity
        }
        */
        gameManager.GetItemAction();
    }

 

} 