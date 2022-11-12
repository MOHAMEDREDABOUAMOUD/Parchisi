using System.Collections;
//package of unity
using UnityEngine;
//application.
using UnityEngine.SceneManagement;
//manipuler les scenes

public class Dice2 : MonoBehaviour
{
    public static int tour=0;
    static int finalSide1 = 0;                                                                                                                                                                                                                    
    static int finalSide2 = 0;
    private Sprite[] diceSides;
    //sprite =image 2D
    private SpriteRenderer rend;
    //how it will be appears in the scene
    public static int pos, pos1, pos2, pos3,posy,posy1,posy2,posy3;
    public static bool posLeft=false, posLeft1=false, posLeft2=false, posLeft3=false,posyLeft=false, posyLeft1=false, posyLeft2=false, posyLeft3=false;
    public static int nbr,selected=0,selectedy=0;
    public static bool access1, access2;
    public static bool accessred,accessyellow;
    public static bool freered,freeyellow;
    public static int l,enterr=0,entery=0,p1st=0,p2nd=0;
    public void startd()
    {
        // Assign Renderer component
        rend = GetComponent<SpriteRenderer>();
        // Load dice sides sprites to array from DiceSides subfolder of Resources folder
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
    }
    public void Start()
    {
        startd();
    }
    void Update()
    {
        if(enterr==4)
        {
            p1st=1;
            p2nd=2;
            SceneManager.LoadScene("MENU 2");
        }
        else if(entery==4)
        {
            p1st=2;
            p2nd=1;
            SceneManager.LoadScene("MENU 2");
        }
        if(tour%2==0)
        {
            bool cant=false;
            if((pos==0 && pos1==0)||(pos==0 && pos2==0)||(pos==0 && pos3==0)||(pos1==0 && pos2==0)||(pos1==0 && pos3==0)||(pos2==0 && pos3==0))
            {
                cant=true;
            }
            if(cant==false)
            {
                if(((finalSide1==5 && access1 && !access2)||(finalSide2==5 && access2 && !access1))&&(pos==-1 || pos1==-1 || pos2==-1 || pos3==-1))
                {
                    freered=true;
                    if (folow_the_pathr2.firstmove == false && pos==-1)
                    {
                        folow_the_pathr2.firstmove = true;pos=0;
                    }
                    else if (folow_the_path12.firstmove1 == false && pos1==-1)
                    {
                        folow_the_path12.firstmove1 = true;pos1=0;
                    }
                    else if (folow_the_path22.firstmove2 == false && pos2==-1)
                    {
                        folow_the_path22.firstmove2 = true;pos2=0;
                    }
                    else if (folow_the_path32.firstmove3 == false && pos3==-1)
                    {
                        folow_the_path32.firstmove3 = true;pos3=0;
                    }
                    access1 = false;
                    access2 = false;
                }
            }
        }
        else
        {
            bool cant=false;
            if((posy==0 && posy1==0)||(posy==0 && posy2==0)||(posy==0 && posy3==0)||(posy1==0 && posy2==0)||(posy1==0 && posy3==0)||(posy2==0 && posy3==0))
            {
                cant=true;
            }
            if(cant==false)
            {
                if(((finalSide1==5 && access1 && !access2)||(finalSide2==5 && access2 && !access1))&&(pos==-1 || pos1==-1 || pos2==-1 || pos3==-1))
                {
                    freeyellow=true;
                    if (follow_the_path_y12.firstmove == false && posy==-1)
                    {
                         follow_the_path_y12.firstmove = true;posy=0;follow_the_path_y12.x=0;
                    }
                    else if (follow_the_path_y_22.firstmove1 == false && posy1==-1)
                    {
                         follow_the_path_y_22.firstmove1 = true;posy1=0;follow_the_path_y_22.x=0;
                    }
                    else if (follow_the_path_y_32.firstmove2 == false && posy2==-1)
                    {
                         follow_the_path_y_32.firstmove2 = true;posy2=0;follow_the_path_y_32.x=0;
                    }
                    else if (follow_the_path_y_42.firstmove3 == false && posy3==-1)
                    {
                         follow_the_path_y_42.firstmove3 = true;posy3=0;follow_the_path_y_42.x=0;
                    }
                    access1 = false;
                    access2 = false; 
                }
            }
        }
        
    }

    // If you left click over the dice then RollTheDice coroutine is started
    public void OnMouseDown()
    { 
        StartCoroutine("RollTheDice");  
    }
    bool canaccess(int nb,int player)
    {
        bool cant1=false,cant2=false,cant3=false,cant4=false;
        if(player==1)
        {
            if(pos>=0)
            {
                for(int i=pos + 1;i<=pos+nb;i++)
                {
                    if((pos1==i && pos2==i)||(pos1==i && pos3==i)||(pos2==i && pos3==i))
                    {
                        cant1=true;
                    }
                    if(i<30)
                    {
                        if((posy==i+34 && pos1==i+34)||(posy==i+34 && posy2==i+34)||(posy==i+34 && posy3==i+34)||(posy1==i+34 && posy2==i+34)||(posy1==i+34 && posy3==i+34)||(posy2==i+34 && posy3==i+34))
                        {
                            cant1=true;
                        }
                    }
                    else if(i>=34 && i<64)
                    {
                        if((posy==i-34 && posy1==i-34)||(posy==i-34 && posy2==i-34)||(posy==i-34 && posy3==i-34)||(posy1==i-34 && posy2==i-34)||(posy1==i-34 && posy3==i-34)||(posy2==i-34 && posy3==i-34))
                        {
                            cant1=true;
                        }
                    }
                }
                if(pos+nb>l) cant1=true;
            }
            else cant1=true;
            if(pos1>=0)
            {
                for(int i=pos1 + 1;i<=pos1+nb;i++)
                {
                    if((pos==i && pos2==i)||(pos==i && pos3==i)||(pos2==i && pos3==i))
                    {
                        cant2=true;
                    }
                    if(i<30)
                    {
                        if((posy==i+34 && pos1==i+34)||(posy==i+34 && posy2==i+34)||(posy==i+34 && posy3==i+34)||(posy1==i+34 && posy2==i+34)||(posy1==i+34 && posy3==i+34)||(posy2==i+34 && posy3==i+34))
                        {
                            cant2=true;
                        }
                    }
                    else if(i>=34 && i<64)
                    {
                        if((posy==i-34 && posy1==i-34)||(posy==i-34 && posy2==i-34)||(posy==i-34 && posy3==i-34)||(posy1==i-34 && posy2==i-34)||(posy1==i-34 && posy3==i-34)||(posy2==i-34 && posy3==i-34))
                        {
                            cant2=true;
                        }
                    }
                }
                if(pos1+nb>l) cant2=true;
            }
            else cant2=true;
            if(pos2>=0)
            {
                for(int i=pos2 + 1;i<=pos2+nb;i++)
                {
                    if((pos1==i && pos==i)||(pos1==i && pos3==i)||(pos==i && pos3==i))
                    {
                        cant3=true;
                    }
                    if(i<30)
                    {
                        if((posy==i+34 && pos1==i+34)||(posy==i+34 && posy2==i+34)||(posy==i+34 && posy3==i+34)||(posy1==i+34 && posy2==i+34)||(posy1==i+34 && posy3==i+34)||(posy2==i+34 && posy3==i+34))
                        {
                            cant3=true;
                        }
                    }
                    else if(i>=34 && i<64)
                    {
                        if((posy==i-34 && posy1==i-34)||(posy==i-34 && posy2==i-34)||(posy==i-34 && posy3==i-34)||(posy1==i-34 && posy2==i-34)||(posy1==i-34 && posy3==i-34)||(posy2==i-34 && posy3==i-34))
                        {
                            cant3=true;
                        }
                    }
                }
                if(pos2+nb>l) cant3=true;
            }
            else cant3=true;
            if(pos3>=0)
            {
                for(int i=pos3 + 1;i<=pos3+nb;i++)
                {
                    if((pos1==i && pos2==i)||(pos1==i && pos==i)||(pos2==i && pos==i))
                    {
                        cant4=true;
                    }
                    if(i<30)
                    {
                        if((posy==i+34 && pos1==i+34)||(posy==i+34 && posy2==i+34)||(posy==i+34 && posy3==i+34)||(posy1==i+34 && posy2==i+34)||(posy1==i+34 && posy3==i+34)||(posy2==i+34 && posy3==i+34))
                        {
                            cant4=true;
                        }
                    }
                    else if(i>=34 && i<64)
                    {
                        if((posy==i-34 && posy1==i-34)||(posy==i-34 && posy2==i-34)||(posy==i-34 && posy3==i-34)||(posy1==i-34 && posy2==i-34)||(posy1==i-34 && posy3==i-34)||(posy2==i-34 && posy3==i-34))
                        {
                            cant4=true;
                        }
                    }
                }
                if(pos3+nb>l) cant4=true;
            }
            else cant4=true;
            if(cant1==true && cant2==true && cant3==true && cant4==true)
            {    Debug.Log("entre false");
                return false;
            }
            else
            {
                Debug.Log("entre true");
                return true;
            } 
        }
        else
        {
            if(posy>=0)
            {
                if(posy+nb>l)
                {
                     cant1=true;////Debug.Log("entre more max");
                }
                else
                {
                    for(int i=posy + 1;i<=posy+nb;i++)
                    {
                        if((posy1==i && posy2==i)||(posy1==i && posy3==i)||(posy2==i && posy3==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+posy);
                            cant1=true;
                        }
                        if(i<30)
                        {
                            if((pos==i+34 && pos1==i+34)||(pos==i+34 && pos2==i+34)||(pos==i+34 && pos3==i+34)||(pos1==i+34 && pos2==i+34)||(pos1==i+34 && pos3==i+34)||(pos2==i+34 && pos3==i+34))
                            {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+posy);
                                cant1=true;
                            }
                        }
                        else if(i>=34 && i<64)
                        {
                            if((pos==i-34 && pos1==i-34)||(pos==i-34 && pos2==i-34)||(pos==i-34 && pos3==i-34)||(pos1==i-34 && pos2==i-34)||(pos1==i-34 && pos3==i-34)||(pos2==i-34 && pos3==i-34))
                            {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+posy);
                                cant1=true;
                            }
                        }
                    }    
                }
                
            }
            else
            {
                cant1=true;////Debug.Log("entre not free"+posy);
            } 
            if(posy1>=0)
            {
                if(posy1+nb>l)
                {
                    cant2=true;////Debug.Log("entre more max");
                } 
                else
                {
                    for(int i=posy1 + 1;i<=posy1+nb;i++)
                    {
                        if((posy==i && posy2==i)||(posy1==i && posy3==i)||(posy2==i && posy3==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+posy);
                            cant2=true;
                        }
                        if(i<30)
                        {
                            if((pos==i+34 && pos1==i+34)||(pos==i+34 && pos2==i+34)||(pos==i+34 && pos3==i+34)||(pos1==i+34 && pos2==i+34)||(pos1==i+34 && pos3==i+34)||(pos2==i+34 && pos3==i+34))
                            {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+posy);
                                cant2=true;
                            }
                        }
                        else if(i>=34 && i<64)
                        {
                            if((pos==i-34 && pos1==i-34)||(pos==i-34 && pos2==i-34)||(pos==i-34 && pos3==i-34)||(pos1==i-34 && pos2==i-34)||(pos1==i-34 && pos3==i-34)||(pos2==i-34 && pos3==i-34))
                            {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+posy);
                                cant2=true;
                            }
                        }
                    }    
                }
                
            }
            else
            {
                cant1=true;////Debug.Log("entre not free"+posy1);
            } 
            if(posy2>=0)
            {
                if(posy2+nb>l)
                {
                    cant3=true;////Debug.Log("entre more max");
                } 
                else{
                    for(int i=posy2 + 1;i<=posy2+nb;i++)
                    {
                        if((posy==i && posy1==i)||(posy==i && posy3==i)||(posy1==i && posy3==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+posy);
                            cant3=true;
                        }
                        if(i<30)
                        {
                            if((pos==i+34 && pos1==i+34)||(pos==i+34 && pos2==i+34)||(pos==i+34 && pos3==i+34)||(pos1==i+34 && pos2==i+34)||(pos1==i+34 && pos3==i+34)||(pos2==i+34 && pos3==i+34))
                            {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+posy);
                                cant3=true;
                            }
                        }
                        else if(i>=34 && i<64)
                        {
                            if((pos==i-34 && pos1==i-34)||(pos==i-34 && pos2==i-34)||(pos==i-34 && pos3==i-34)||(pos1==i-34 && pos2==i-34)||(pos1==i-34 && pos3==i-34)||(pos2==i-34 && pos3==i-34))
                            {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+posy);
                                cant3=true;
                            }
                        }
                    }    
                }
                
            }
            else
            {
                cant1=true;////Debug.Log("entre not free"+posy2);
            } 
            if(posy3>=0)
            {
                if(posy3+nb>l) 
                {
                    cant4=true;////Debug.Log("entre more max");
                }
                else{
                    for(int i=posy3 + 1;i<=posy3+nb;i++)
                    {
                        if((posy==i && posy1==i)||(posy==i && posy2==i)||(posy1==i && posy2==i))
                        {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+posy);
                            cant4=true;
                        }
                        if(i<30)
                        {
                            if((pos==i+34 && pos1==i+34)||(pos==i+34 && pos2==i+34)||(pos==i+34 && pos3==i+34)||(pos1==i+34 && pos2==i+34)||(pos1==i+34 && pos3==i+34)||(pos2==i+34 && pos3==i+34))
                            {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+posy);
                                cant4=true;
                            }
                        }
                        else if(i>=34 && i<64)
                        {
                            if((pos==i-34 && pos1==i-34)||(pos==i-34 && pos2==i-34)||(pos==i-34 && pos3==i-34)||(pos1==i-34 && pos2==i-34)||(pos1==i-34 && pos3==i-34)||(pos2==i-34 && pos3==i-34))
                            {
                                ////Debug.Log("entre boucle"+i+" "+nb+" "+posy);
                                cant4=true;
                            }
                        }
                    }
                }
            }
            else
            {
                cant1=true;////Debug.Log("entre not free"+posy3);
            } 
            if(cant1==true && cant2==true && cant3==true && cant4==true)
            {    //Debug.Log("entre false");
                return false;
            }
            else
            {//Debug.Log("entre true");
                return true;
            } 
        }
    }
    // Coroutine that rolls the dice
    public IEnumerator RollTheDice()
    {
       // Debug.Log(pos+" "+pos1+" "+pos2+" "+pos3);
        if (access1 == false && access2 == false)//////////////////////////////////////////////////////////////////////////////////////////////////
        {
            if(finalSide1!=finalSide2) tour++;////////////////////////////////////////////////////////////////////////////////////////////////////
            if(tour%2==0)
            {
                accessred=true; 
                accessyellow=false;
                rend.GetComponent<SpriteRenderer>().material.color = Color.red;
            }
            else
            {
                accessred=false;
                accessyellow=true;
                rend.GetComponent<SpriteRenderer>().material.color = Color.yellow;
            }
            numberImg2.hideimg(); numberImg2.show = false;////////////////
            numberImg12.hideimg(); numberImg12.show = false;///////////////////
            // corountineAllowed = false;
            int randomDiceSide = 0;
            for (int i = 0; i <= 20; i++)
            {
                randomDiceSide = Random.Range(0, 36);
                rend.sprite = diceSides[randomDiceSide];
                yield return new WaitForSeconds(0.05f);
            }
            //////Debug.Log(randomDiceSide+1);
            switch (randomDiceSide + 1)
            {
                case 1:
                    finalSide1 = 1;
                    finalSide2 = 1;
                    break;
                case 2:
                    finalSide1 = 1;
                    finalSide2 = 2;
                    break;
                case 3:
                    finalSide1 = 1;
                    finalSide2 = 3;
                    break;
                case 4:
                    finalSide1 = 1;
                    finalSide2 = 4;
                    break;
                case 5:
                    finalSide1 = 1;
                    finalSide2 = 5;
                    break;
                case 6:
                    finalSide1 = 1;
                    finalSide2 = 6;
                    break;
                case 7:
                    finalSide1 = 2;
                    finalSide2 = 1;
                    break;
                case 8:
                    finalSide1 = 2;
                    finalSide2 = 2;
                    break;
                case 9:
                    finalSide1 = 2;
                    finalSide2 = 3;
                    break;
                case 10:
                    finalSide1 = 2;
                    finalSide2 = 4;
                    break;
                case 11:
                    finalSide1 = 2;
                    finalSide2 = 5;
                    break;
                case 12:
                    finalSide1 = 2;
                    finalSide2 = 6;
                    break;
                case 13:
                    finalSide1 = 3;
                    finalSide2 = 1;
                    break;
                case 14:
                    finalSide1 = 3;
                    finalSide2 = 2;
                    break;
                case 15:
                    finalSide1 = 3;
                    finalSide2 = 3;
                    break;
                case 16:
                    finalSide1 = 3;
                    finalSide2 = 4;
                    break;
                case 17:
                    finalSide1 = 3;
                    finalSide2 = 5;
                    break;
                case 18:
                    finalSide1 = 3;
                    finalSide2 = 6;
                    break;
                case 19:
                    finalSide1 = 4;
                    finalSide2 = 1;
                    break;
                case 20:
                    finalSide1 = 4;
                    finalSide2 = 2;
                    break;
                case 21:
                    finalSide1 = 4;
                    finalSide2 = 3;
                    break;
                case 22:
                    finalSide1 = 4;
                    finalSide2 = 4;
                    break;
                case 23:
                    finalSide1 = 4;
                    finalSide2 = 5;
                    break;
                case 24:
                    finalSide1 = 4;
                    finalSide2 = 6;
                    break;
                case 25:
                    finalSide1 = 5;
                    finalSide2 = 1;
                    break;
                case 26:
                    finalSide1 = 5;
                    finalSide2 = 2;
                    break;
                case 27:
                    finalSide1 = 5;
                    finalSide2 = 3;
                    break;
                case 28:
                    finalSide1 = 5;
                    finalSide2 = 4;
                    break;
                case 29:
                    finalSide1 = 5;
                    finalSide2 = 5;
                    break;
                case 30:
                    finalSide1 = 5;
                    finalSide2 = 6;
                    break;
                case 31:
                    finalSide1 = 6;
                    finalSide2 = 1;
                    break;
                case 32:
                    finalSide1 = 6;
                    finalSide2 = 2;
                    break;
                case 33:
                    finalSide1 = 6;
                    finalSide2 = 3;
                    break;
                case 34:
                    finalSide1 = 6;
                    finalSide2 = 4;
                    break;
                case 35:
                    finalSide1 = 6;
                    finalSide2 = 5;
                    break;
                case 36:
                    finalSide1 = 6;
                    finalSide2 = 6;
                    break;
            }
            if(tour%2==0)
            {
                numberImg2.setimg(finalSide1);
                numberImg12.setimg(finalSide2);
                folow_the_pathr2.click = false;
                folow_the_path12.click = false;
                folow_the_path22.click = false;
                folow_the_path32.click = false;
                bool cant=false,cant2=true;
                if((pos==0 && pos1==0)||(pos==0 && pos2==0)||(pos==0 && pos3==0)||(pos1==0 && pos2==0)||(pos1==0 && pos3==0)||(pos2==0 && pos3==0))
                {
                    cant=true;
                }
                if((posy==34 && posy1==34)||(posy==34 && posy2==34)||(posy==34 && posy3==34)||(posy1==34 && posy2==34)||(posy1==34 && posy3==34)||(posy2==34 && posy3==34))
                {
                    cant=true;
                }
                if(pos!=0 && pos1!=0 && pos2!=0 && pos3!=0 && posy!=34 && posy1!=34 && posy2!=34 && posy3!=34)
                {
                    cant2=false;
                }
                int cp=0;
                if(pos==-1) cp++;
                if(pos1==-1) cp++;
                if(pos2==-1) cp++;
                if(pos3==-1) cp++;
                if ((cant2==false)&&(finalSide1 == 5 && finalSide2 == 5)&&(cp>=2))
                {
                    access1 = false;
                    access2 = false;
                    freered=true;
                    cp=0;
                    if (folow_the_pathr2.firstmove == false && pos==-1 && cp<2) 
                    {
                        folow_the_pathr2.firstmove = true;pos=0;cp++;
                    }
                    if (folow_the_path12.firstmove1 == false && pos1==-1 && cp<2) 
                    {
                        folow_the_path12.firstmove1 = true;pos1=0;cp++;
                    }
                    if (folow_the_path22.firstmove2 == false && pos2==-1 && cp<2)
                    {
                        folow_the_path22.firstmove2 = true;pos2=0;cp++;
                    }
                    if (folow_the_path32.firstmove3 == false && pos3==-1 && cp<2)
                    {
                        folow_the_path32.firstmove3 = true;pos3=0;cp++;
                    } 
                }
                else if ((pos==-1 || pos1==-1 || pos2==-1 || pos3==-1)&&(cant==false)&&(finalSide1 == 5 || finalSide2 == 5 || finalSide1 + finalSide2 == 5))
                {
                    freered=true;
                    if (folow_the_pathr2.firstmove == false && pos==-1)
                    {
                        folow_the_pathr2.firstmove = true;pos=0;
                    }
                    else if (folow_the_path12.firstmove1 == false && pos1==-1)
                    {
                        folow_the_path12.firstmove1 = true;pos1=0;
                    }
                    else if (folow_the_path22.firstmove2 == false && pos2==-1)
                    {
                        folow_the_path22.firstmove2 = true;pos2=0;
                    }
                    else if (folow_the_path32.firstmove3 == false && pos3==-1)
                    {
                        folow_the_path32.firstmove3 = true;pos3=0;
                    }
                    if (finalSide1 == 5)
                    {
                        access2=canaccess(finalSide2,1);
                        access1 = false;
                    }
                    else if (finalSide2 == 5)
                    {
                        access1=canaccess(finalSide1,1);
                        access2 = false;
                    }
                    else if (finalSide2 + finalSide1 == 5)
                    {
                        access1 = false;
                        access2 = false;
                    }
                }
                else if (pos == -1 && pos1 == -1 && pos2 == -1 && pos3 == -1)
                {
                    access1 = false;
                    access2 = false;
                }
                else
                {
                    access1=canaccess(finalSide1,1);
                    access2=canaccess(finalSide2,1);
                }
            }
            else
            {
                numberImg2.setimg(finalSide1);
                numberImg12.setimg(finalSide2);
                follow_the_path_y12.click = false;
                follow_the_path_y_22.click = false;
                follow_the_path_y_32.click = false;
                follow_the_path_y_42.click = false;
                bool cant=false,cant2=true;
                if((posy==0 && posy1==0)||(posy==0 && posy2==0)||(posy==0 && posy3==0)||(posy1==0 && posy2==0)||(posy1==0 && posy3==0)||(posy2==0 && posy3==0))
                {
                    cant=true;
                }
                if((pos==34 && pos1==34)||(pos==34 && pos2==34)||(pos==34 && pos3==34)||(pos1==34 && pos2==34)||(pos1==34 && pos3==34)||(pos2==34 && pos3==34))
                {
                    cant=true;
                }
                if(pos!=34 && pos1!=34 && pos2!=34 && pos3!=34 && posy!=0 && posy1!=0 && posy2!=0 && posy3!=0)
                {
                    cant2=false;
                }
                int cp=0;
                if(posy==-1) cp++;
                if(posy1==-1) cp++;
                if(posy2==-1) cp++;
                if(posy3==-1) cp++;
                if ((cant2==false)&&(finalSide1 == 5 && finalSide2 == 5)&&(cp>=2))
                {
                    access1 = false;
                    access2 = false;
                    freeyellow=true;
                    cp=0;
                    if (follow_the_path_y12.firstmove == false && posy==-1 && cp<2) 
                    {
                        follow_the_path_y12.firstmove = true;posy=0;follow_the_path_y12.x=0;cp++;
                    }
                    if (follow_the_path_y_22.firstmove1 == false && posy1==-1 && cp<2) 
                    {
                        follow_the_path_y_22.firstmove1 = true;posy1=0;follow_the_path_y_22.x=0;cp++;
                    }
                    if (follow_the_path_y_32.firstmove2 == false && posy2==-1 && cp<2)
                    {
                        follow_the_path_y_32.firstmove2 = true;posy2=0;follow_the_path_y_32.x=0;cp++;
                    }
                    if (follow_the_path_y_42.firstmove3 == false && posy3==-1 && cp<2)
                    {
                        follow_the_path_y_42.firstmove3 = true;posy3=0;follow_the_path_y_42.x=0;cp++;
                    } 
                }
                else if((posy==-1 || posy1==-1 || posy2==-1 || posy3==-1)&&(cant==false)&&(finalSide1 == 5 || finalSide2 == 5 || finalSide1 + finalSide2 == 5))
                {
                    freeyellow=true;
                    if (follow_the_path_y12.firstmove == false && posy==-1)
                    {
                         follow_the_path_y12.firstmove = true;posy=0;follow_the_path_y12.x=0;
                    }
                    else if (follow_the_path_y_22.firstmove1 == false && posy1==-1)
                    {
                         follow_the_path_y_22.firstmove1 = true;posy1=0;follow_the_path_y_22.x=0;
                    }
                    else if (follow_the_path_y_32.firstmove2 == false && posy2==-1)
                    {
                         follow_the_path_y_32.firstmove2 = true;posy2=0;follow_the_path_y_32.x=0;
                    }
                    else if (follow_the_path_y_42.firstmove3 == false && posy3==-1)
                    {
                         follow_the_path_y_42.firstmove3 = true;posy3=0;follow_the_path_y_42.x=0;
                    }
                    if (finalSide1 == 5)
                    {
                        access2=canaccess(finalSide2,2);
                        access1 = false;
                    }
                    else if (finalSide2 == 5)
                    {
                        access1=canaccess(finalSide1,2);
                        access2 = false;
                    }
                    else if (finalSide2 + finalSide1 == 5)
                    {
                        access1 = false;
                        access2 = false; 
                    }
                }
                else if (posy == -1 && posy1 == -1 && posy2 == -1 && posy3 == -1)
                {
                    access1 = false;
                    access2 = false;
                }
                else
                {
                    access1=canaccess(finalSide1,2);
                    access2=canaccess(finalSide2,2);
                }
            }
        }
    }
}
