using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow_the_path_g24 : MonoBehaviour
{
    //[SerializeField] private GameObject dest;
    [SerializeField] Transform[] waypoints;
    [SerializeField] Transform[] waypoints1;
    [SerializeField] Transform firstplace1;
    [SerializeField] Transform final2;
    [SerializeField] public static Transform curentpos;
    public static bool allowMove1 = false,firstmove1=false;
    public static bool click =false;
    public static int Length;
    public static bool initpos=false;
    public static int x;
    private void Start()
    {
        transform.position = firstplace1.position;
        Dice4.posg1 = -1;
        x=-1;
        Length=waypoints.Length;
    }

    void Update()
    {
        if (firstmove1 == true && transform.position == firstplace1.position && Dice4.freegreen)
        {
            if (Dice4.posg == 0)
            {
                if(Dice4.posg2!=0 && Dice4.posg3!=0)
                {
                    Dice4.posg1 = 0;
                    if (Dice4.posgLeft == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice4.posgLeft1 = true;
                    }
                }
            }
            else if (Dice4.posg2 == 0)
            {
                if(Dice4.posg!=0 && Dice4.posg3!=0)
                {
                    Dice4.posg1 = 0;
                    if (Dice4.posgLeft2 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice4.posgLeft1 = true;
                    }
                }
            }
            else if (Dice4.posg3 == 0)
            {
                if(Dice4.posg!=0 && Dice4.posg2!=0)
                {
                    Dice4.posg1 = 0;
                    if (Dice4.posgLeft3 == true)
                    {
                        transform.position = waypoints[0].position;
                    }
                    else
                    {
                        transform.position = waypoints1[0].position;
                        Dice4.posgLeft1 = true;
                    }
                }
            }///////////////////////////////////////////////////////////ajouter le cas de player red
            else
            {
                if(folow_the_path4.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,3);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,3);
                    }
                    folow_the_path4.initpos=true;
                }
                else if(folow_the_path14.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,3);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,3);
                    }
                    folow_the_path14.initpos=true;
                }
                else if(folow_the_path24.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,3);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,3);
                    }
                    folow_the_path24.initpos=true;
                }
                else if(folow_the_path34.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,3);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,3);
                    }
                    folow_the_path34.initpos=true;
                }
                else if(follow_the_path_y14.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,3);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,3);
                    }
                    follow_the_path_y14.initpos=true;
                }
                else if(follow_the_path_y_24.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,3);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,3);
                    }
                    follow_the_path_y_24.initpos=true;
                }
                else if(follow_the_path_y_34.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,3);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,3);
                    }
                    follow_the_path_y_34.initpos=true;
                }
                else if(follow_the_path_y_44.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,3);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,3);
                    }
                    follow_the_path_y_44.initpos=true;
                }
                else if(follow_the_path_b14.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,3);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,3);
                    }
                    follow_the_path_b14.initpos=true;
                }
                else if(follow_the_path_b24.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,3);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,3);
                    }
                    follow_the_path_b24.initpos=true;
                }
                else if(follow_the_path_b34.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,3);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,3);
                    }
                    follow_the_path_b34.initpos=true;
                }
                else if(follow_the_path_b44.x==17)
                {
                    Debug.Log("enter eat");
                    if(Dice4.access1==false)
                    {
                        numberImg4.setimg(20);
                        Dice4.access1=Dice4.canaccess(20,3);
                    }
                    else if(Dice4.access2==false)
                    {
                        numberImg14.setimg(20);
                        Dice4.access2=Dice4.canaccess(20,3);
                    }
                    follow_the_path_b44.initpos=true;
                }
                else
                {
                    Dice4.posg1 = 0;
                    transform.position = waypoints[0].position;    
                }
            }
            x=17;
            if(follow_the_path_g14.firstmove==false && follow_the_path_g3.firstmove2==false && follow_the_path_g4.firstmove3==false) Dice4.freegreen=false;
            firstmove1=false;
        }
        else if(initpos==true)
        {
            transform.position = firstplace1.position;
            Dice4.posg1= -1;
            x=-1;
            initpos=false;
        }
        else if (click == true && transform.position!=firstplace1.position)
        {
            StartCoroutine(move());
            click = false;
        }
    }
    private void OnMouseDown()
    {
        if(Dice4.accessgreen)
        {
            if (Dice4.posg >= 0)
            {
                if (numberImg4.show == true)
                {
                    numberImg4.hideimg(); numberImg4.show = false;///////////////
                    numberImg14.hideimg(); numberImg14.show = false;//////////////
                    Dice4.selectedg = 0;
                }
                else
                {
                    numberImg4.showimg(); numberImg4.show = true;///////////////
                    numberImg14.showimg(); numberImg14.show = true;/////////////////
                    Dice4.selectedg = 2;
                }
            }    
        }
        
    }
    IEnumerator move()
    {
        if(Dice4.posg1 + Dice4.nbr == waypoints.Length)
        {
            numberImg4.hideimg();numberImg4.show = false;////////////////
            numberImg14.hideimg();numberImg14.show = false;///////////////////
            Dice4.posgLeft = false;
            for (int i =Dice4.posg1;i< Dice4.posg1 + Dice4.nbr ; i++)
            {
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.5f);
            }
            Dice4.posg1= Dice4.posg1 + Dice4.nbr;
            x=x+ Dice4.nbr;
            transform.position = final2.position;
            if(Dice4.access1==false)
            {
                numberImg4.setimg(10);
                Dice4.access1=Dice4.canaccess(10,3);
            }
            else if(Dice4.access2==false)
            {
                numberImg14.setimg(10);
                Dice4.access2=Dice4.canaccess(10,3);
            }
            Dice4.enterg++;
        }
        else if (Dice4.posg1 + Dice4.nbr <= waypoints.Length - 1)
        {
            numberImg4.hideimg(); numberImg4.show = false;////////////////
            numberImg14.hideimg(); numberImg14.show = false;///////////////////
            Dice4.posgLeft1 = false;
            for (int i =Dice4.posg1;i<= Dice4.posg1 + Dice4.nbr; i++)
            {
                //Time.timeScale = 1f;
                transform.position = waypoints[i].position;
                yield return new WaitForSeconds(0.1f);
                //Time.timeScale = 0f;
            }
            Dice4.posg1 += Dice4.nbr;
            for(int i=1;i<=Dice4.nbr;i++)
            {
                if(x==68)
                {
                    x=0;x++;
                }
                else if(Dice4.posg1<63)
                {
                    x++;  
                }
                else x=100;
            }
            if (Dice4.posg == Dice4.posg1)
            {
                if (Dice4.posgLeft == true)
                {
                    transform.position = waypoints[Dice4.posg1].position;
                }
                else
                {
                    transform.position = waypoints1[Dice4.posg1].position;
                    Dice4.posgLeft1 = true;
                }
            }
            else if (Dice4.posg2 == Dice4.posg1)
            {
                if (Dice4.posgLeft2 == true)
                {
                    transform.position = waypoints[Dice4.posg1].position;
                }
                else
                {
                    transform.position = waypoints1[Dice4.posg1].position;
                    Dice4.posgLeft1 = true;
                }
            }
            else if (Dice4.posg3 == Dice4.posg1)
            {
                if (Dice4.posgLeft3 == true)
                {
                    transform.position = waypoints[Dice4.posg1].position;
                }
                else
                {
                    transform.position = waypoints1[Dice4.posg1].position;
                    Dice4.posgLeft1 = true;
                }
            }///////////////////////////////////////////////////////////////////////////////ajouter le cas de player red
            if(x==folow_the_path4.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,3);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,3);
                }
                folow_the_path4.initpos=true;
            }
            else if(x==folow_the_path14.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,3);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,3);
                }
                folow_the_path14.initpos=true;
            }
            else if(x==folow_the_path24.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,3);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,3);
                }
                folow_the_path24.initpos=true;
            }
            else  if(x==folow_the_path34.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,3);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,3);
                }
                folow_the_path34.initpos=true;
            }
            else if(x==follow_the_path_y14.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,3);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,3);
                }
                follow_the_path_y14.initpos=true;
            }
            else if(x==follow_the_path_y_24.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,3);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,3);
                }
                follow_the_path_y_24.initpos=true;
            }
            else if(x==follow_the_path_y_34.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,3);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,3);
                }
                follow_the_path_y_34.initpos=true;
            }
            else if(x==follow_the_path_y_44.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,3);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,3);
                }
                follow_the_path_y_44.initpos=true;
            }
            else if(x==follow_the_path_b14.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,3);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,3);
                }
                follow_the_path_b14.initpos=true;
            }
            else if(x==follow_the_path_b24.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,3);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,3);
                }
                follow_the_path_b24.initpos=true;
            }
            else if(x==follow_the_path_b34.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,3);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,3);
                }
                follow_the_path_b34.initpos=true;
            }
            else if(x==follow_the_path_b44.x)
            {
                Debug.Log("enter eat");
                if(Dice4.access1==false)
                {
                    numberImg4.setimg(20);
                    Dice4.access1=Dice4.canaccess(20,3);
                }
                else if(Dice4.access2==false)
                {
                    numberImg14.setimg(20);
                    Dice4.access2=Dice4.canaccess(20,3);
                }
                follow_the_path_b44.initpos=true;
            }
            //Time.timeScale = 1f;
            //transform.position = waypoints[waypointsIndex + nbr].position;
            //transform.position = Vector2.MoveTowards(transform.position,waypoints[waypointsIndex + nbr].position, movspeed );
            
        }
    }
}
